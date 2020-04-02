using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Windows.Forms.DataVisualization.Charting;

namespace APDProjectOne
{
    public partial class MainForm : Form
    {
        private WaveFileReader wfReader;
        private string filePath;
        private int frameLength = 40; // (10 - 40 ms)
        private List<float> zcrData;
        private List<float> volumeData;
        private List<float> steData;
        private float? minVolume;
        private float? maxVolume;
        private float? meanVolume;
        private float vdr = 0;
        private float vstd = 0;
        private float lster = 0;
        private float hzcrr = 0;
        private float avZcr = 0;
        private float avSte = 0;

        public MainForm()
        {
            InitializeComponent();

            msInput.Value = 40;
            frameLength = (int)msInput.Value;
        }

        private void OnOpenFileClick(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = openFileDialog.FileName;
                    fileLabel.Text = "File: " + filePath;
                    
                    wfReader = new WaveFileReader(filePath);

                    waveViewer.WaveStream = wfReader;
                    waveViewer.SamplesPerPixel = (int)(wfReader.SampleCount / waveViewer.Width);

                    // Calculate frame-length-independent values
                    CalculateAv();

                    PaintCharts();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Resize waveViewer
            waveViewer.Width = this.Width - 2*(20);
            if(wfReader != null)
                waveViewer.SamplesPerPixel = (int)(wfReader.SampleCount / waveViewer.Width);
        }

        private void msInput_ValueChanged(object sender, EventArgs e)
        {
            frameLength = (int)msInput.Value;
        }

        private void PaintCharts()
        {
            PopulateChart(volumeChart, ref volumeData, (float[] frame, int bytesRead, ISampleProvider _) =>
            {
                float sum = 0;
                for (int i = 0; i < bytesRead; i++)
                    sum += frame[i] * frame[i];
                float value = (float)Math.Sqrt(sum / (float)bytesRead);
                // Save min and max volume
                minVolume = (minVolume == null || minVolume > value) ? value : minVolume;
                maxVolume = (maxVolume == null || maxVolume < value) ? value : maxVolume;
                return value;
            });

            PopulateChart(steChart, ref steData, (float[] frame, int bytesRead, ISampleProvider _) =>
            {
                float sum = 0;
                for (int i = 0; i < bytesRead; i++)
                    sum += frame[i] * frame[i];
                return sum / (float)bytesRead;
            });

            PopulateChart(zcrChart, ref zcrData, (float[] frame, int bytesRead, ISampleProvider sp) =>
            {
                float sum = 0;
                for (int i = 1; i < bytesRead; i++)
                    sum += Math.Abs(Math.Sign(frame[i]) - Math.Sign(frame[i - 1]));
                return sum * sp.WaveFormat.SampleRate / (2.0f * (float)bytesRead);
            });

            // Calculate mean volume
            meanVolume = volumeData.Sum() / volumeData.Count;

            // Calculate standard deviation
            CalculateStdDeviation();
            vstdLabel.Text = "VSTD: " + vstd.ToString();

            // Calculate silence ratio
            using (DataTable dt = new DataTable())
            {
                dt.Columns.Add("Frame", typeof(int));
                dt.Columns.Add("Value", typeof(float));

                for(int n = 0; n < zcrData.Count; n++)
                {
                    float value = (volumeData[n] < 0.02 && zcrData[n] < 50.0) ? 1.0f : 0.0f;
                    dt.Rows.Add(n, value);
                }

                srChart.DataSource = dt;
                srChart.Series["Series1"].XValueMember = "Frame";
                srChart.Series["Series1"].YValueMembers = "Value";
                srChart.Series["Series1"].ChartType = SeriesChartType.Line;
            }

            // Calculate volume dynamic range
            vdr = ((float)maxVolume - (float)minVolume) / (float)maxVolume;
            vdrLabel.Text = "VDR: " + vdr.ToString();

            // Calculate low short time energy ratio
            CalculateLster();
            lsterLabel.Text = "LSTER: " + lster.ToString();

            // Calculate high zero crossing rate ratio
            CalculateHzcrr();
            hzcrrLabel.Text = "HZCRR: " + hzcrr.ToString();
        }

        private void PopulateChart(Chart chart, ref List<float> dataList, Func<float[], int, ISampleProvider, float> calc)
        {
            if (filePath == null) return;
            dataList = new List<float>();
            using (WaveFileReader reader = new WaveFileReader(filePath))
            {
                ISampleProvider sampleProvider = reader.ToSampleProvider();
                List<float> valuePerFrame = new List<float>();

                int frameSizeBytes = sampleProvider.WaveFormat.AverageBytesPerSecond * frameLength / 1000;
                int frameSizeFloats = frameSizeBytes / sizeof(float);
                float[] buffer = new float[frameSizeFloats];

                DataTable dt = new DataTable();
                dt.Columns.Add("Frame", typeof(int));
                dt.Columns.Add("Value", typeof(float));

                int frameNumber = 0;
                while (true)
                {
                    int bytesRead = sampleProvider.Read(buffer, 0, frameSizeFloats);
                    if (bytesRead <= 0)
                        break;

                    float value = calc(buffer, bytesRead, sampleProvider);
                    dataList.Add(value);
                    dt.Rows.Add(frameNumber, value);
                    frameNumber++;
                }

                chart.DataSource = dt;
                chart.Series["Series1"].XValueMember = "Frame";
                chart.Series["Series1"].YValueMembers = "Value";
                chart.Series["Series1"].ChartType = SeriesChartType.Line;
            }
        }

        private void CalculateStdDeviation()
        {
            float sum = 0;
            foreach (float v in volumeData)
            {
                sum += (v - (float)meanVolume) * (v - (float)meanVolume);
            }
            float variance = sum / volumeData.Count;
            float stdDev = (float)Math.Sqrt((double)variance);

            // Normalize standard deviation by maximum volume in clip
            vstd = stdDev / (float)maxVolume;
        }

        private void CalculateAv()
        {
            if (filePath == null) return;
            // Calculate average ZCR and STE for 1-second window
            using (WaveFileReader reader = new WaveFileReader(filePath))
            {
                ISampleProvider sampleProvider = reader.ToSampleProvider();
                List<float> zcrPerSecond = new List<float>();

                // One second window
                int windowSizeFloats = sampleProvider.WaveFormat.AverageBytesPerSecond / sizeof(float);
                float[] buffer = new float[windowSizeFloats];
                avZcr = 0;
                avSte = 0;
                int windowsCount = 0;
                while (true)
                {
                    int bytesRead = sampleProvider.Read(buffer, 0, windowSizeFloats);
                    if (bytesRead <= 0)
                        break;

                    // Calculate ZCR in window
                    float sum = 0;
                    for (int i = 1; i < bytesRead; i++)
                        sum += Math.Abs(Math.Sign(buffer[i]) - Math.Sign(buffer[i - 1]));
                    float value = sum * sampleProvider.WaveFormat.SampleRate / (2.0f * (float)bytesRead);
                    avZcr += value;

                    // Calculate STE in window
                    sum = 0;
                    for (int i = 0; i < bytesRead; i++)
                        sum += buffer[i] * buffer[i];
                    value = sum / (float)bytesRead;
                    avSte += value;

                    windowsCount++;
                }
                avZcr /= (float)windowsCount;
                avSte /= (float)windowsCount;
            }
        }

        private void CalculateHzcrr()
        {
            float sum = 0;
            foreach (float z in zcrData)
                sum += Math.Sign(z - 1.5f * avZcr) + 1;
            hzcrr = sum / (2.0f * zcrData.Count);
        }

        private void CalculateLster()
        {
            float sum = 0;
            foreach (float s in steData)
                sum += Math.Sign(0.5f * avSte - s) + 1;
            lster = sum / (2.0f * steData.Count);
        }

        private void buttonRepaint_Click(object sender, EventArgs e)
        {
            PaintCharts();
        }
    }
}
