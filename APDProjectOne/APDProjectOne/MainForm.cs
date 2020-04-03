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
        private int autocorParam; // (1 - clip length in samples)
        private List<double> zcrData;
        private List<double> volumeData;
        private List<double> steData;
        private List<double> autocorData;
        private List<double> amdfData;
        private double? minVolume;
        private double? maxVolume;
        private double? meanVolume;
        private double? meanZcr;
        private double vdr = 0;
        private double vstd = 0;
        private double zstd = 0;
        private double lster = 0;
        private double hzcrr = 0;
        private double avZcr = 0;
        private double avSte = 0;

        public MainForm()
        {
            InitializeComponent();

            msInput.Value = 40;
            frameLength = (int)msInput.Value;
            autocorInput.Value = 8;
            autocorParam = (int)autocorInput.Value;
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

                    autocorInput.Maximum = wfReader.SampleCount;

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
            // I hate WinForms for making this so hard or myself for not figuring an easier way
            int newX = (int)((this.Width * 230.0) / 1700.0);
            waveViewer.Location = new Point(newX, waveViewer.Location.Y);
            int newWidth = (int)((this.Width - waveViewer.Location.X) * 0.922);
            waveViewer.Width = newWidth;
            if (wfReader != null)
                waveViewer.SamplesPerPixel = (int)Math.Round((double)wfReader.SampleCount / (double)newWidth);
        }

        private void msInput_ValueChanged(object sender, EventArgs e)
        {
            frameLength = (int)msInput.Value;
        }

        private void PaintCharts()
        {
            PopulateChart(volumeChart, ref volumeData, (float[] frame, int samplesRead, ISampleProvider _) =>
            {
                double sum = 0;
                for (int i = 0; i < samplesRead; i++)
                    sum += (double)frame[i] * (double)frame[i];
                double value = Math.Sqrt(sum / samplesRead);
                // Save min and max volume
                minVolume = (minVolume == null || minVolume > value) ? value : minVolume;
                maxVolume = (maxVolume == null || maxVolume < value) ? value : maxVolume;
                return value;
            });

            PopulateChart(steChart, ref steData, (float[] frame, int samplesRead, ISampleProvider _) =>
            {
                double sum = 0;
                for (int i = 0; i < samplesRead; i++)
                    sum += (double)frame[i] * (double)frame[i];
                return sum / samplesRead;
            });

            PopulateChart(zcrChart, ref zcrData, (float[] frame, int samplesRead, ISampleProvider sp) =>
            {
                double sum = 0;
                for (int i = 1; i < samplesRead; i++)
                    sum += Math.Abs(Math.Sign(frame[i]) - Math.Sign(frame[i - 1]));
                return sum * sp.WaveFormat.SampleRate / (2.0 * samplesRead);
            });

            PopulateChart(autocorChart, ref autocorData, (float[] frame, int samplesRead, ISampleProvider _) =>
            {
                double sum = 0;
                for (int i = 0; i < samplesRead - autocorParam; i++)
                {
                    sum += (double)frame[i] * (double)frame[i + autocorParam];
                }
                return sum;
            });

            PopulateChart(amdfChart, ref amdfData, (float[] frame, int samplesRead, ISampleProvider _) =>
            {
                double sum = 0;
                for (int i = 0; i < samplesRead - autocorParam; i++)
                {
                    sum += Math.Abs((double)frame[i + autocorParam] - (double)frame[i]);
                }
                return sum;
            });

            // Calculate mean volume
            meanVolume = volumeData.Average();
            meanZcr = zcrData.Average();

            // Calculate standard deviations
            CalculateStdDeviations();
            vstdLabel.Text = "VSTD: " + vstd.ToString();
            zstdLabel.Text = "ZSTD: " + zstd.ToString();

            // Calculate silence ratio
            CreateChart(srChart, (DataTable dt) =>
            {
                for (int n = 0; n < zcrData.Count; n++)
                {
                    double value = (volumeData[n] < 0.02 && zcrData[n] < 50.0) ? 1.0 : 0.0;
                    dt.Rows.Add(n, value);
                }

                return 0;
            });

            // Calculate volume dynamic range
            vdr = ((double)maxVolume - (double)minVolume) / (double)maxVolume;
            vdrLabel.Text = "VDR: " + vdr.ToString();

            // Calculate low short time energy ratio
            CalculateLster();
            lsterLabel.Text = "LSTER: " + lster.ToString();

            // Calculate high zero crossing rate ratio
            CalculateHzcrr();
            hzcrrLabel.Text = "HZCRR: " + hzcrr.ToString();

            // Detect voiceless speech
            CreateChart(voicelessChart, (DataTable dt) =>
            {
                for (int n = 0; n < steData.Count; n++)
                {
                    double value = (steData[n] < 0.03 && zcrData[n] > 6000.0) ? 1.0 : 0.0;
                    dt.Rows.Add(n, value);
                }
                return 0;
            });

            // Detect voiced 
            CreateChart(voicedChart, (DataTable dt) =>
            {
                for (int n = 0; n < steData.Count; n++)
                {
                    double value = (steData[n] >= 0.01 && zcrData[n] < 6000.0) ? 1.0 : 0.0;
                    dt.Rows.Add(n, value);
                }
                return 0;
            });
        }

        private void PopulateChart(Chart chart, ref List<double> dataList, Func<float[], int, ISampleProvider, double> calc)
        {
            if (filePath == null) return;
            dataList = new List<double>();
            using (WaveFileReader reader = new WaveFileReader(filePath))
            {
                ISampleProvider sampleProvider = reader.ToSampleProvider();
                int frameSizeBytes = sampleProvider.WaveFormat.AverageBytesPerSecond * frameLength / 1000;
                int frameSizeFloats = frameSizeBytes / sizeof(double);
                float[] buffer = new float[frameSizeFloats];

                List<double> tmpList = new List<double>();
                CreateChart(chart, (DataTable dt) =>
                {
                    int frameNumber = 0;
                    while (true)
                    {
                        int samplesRead = sampleProvider.Read(buffer, 0, frameSizeFloats);
                        if (samplesRead <= 0)
                            break;

                        double value = calc(buffer, samplesRead, sampleProvider);
                        tmpList.Add(value);
                        dt.Rows.Add(frameNumber, value);
                        frameNumber++;
                    }
                    return 0;
                });
                dataList = tmpList;
            }
        }

        private void CreateChart(Chart chart, Func<DataTable, int> calc)
        {
            using (DataTable dt = new DataTable())
            {
                dt.Columns.Add("Frame", typeof(int));
                dt.Columns.Add("Value", typeof(double));

                calc(dt);

                chart.DataSource = dt;
                chart.Series["Series1"].XValueMember = "Frame";
                chart.Series["Series1"].YValueMembers = "Value";
                chart.Series["Series1"].ChartType = SeriesChartType.Line;
            }
        }

        private void CalculateStdDeviations()
        {
            // Calculate volume standard deviation
            double sum = 0;
            foreach (double v in volumeData)
            {
                sum += (v - (double)meanVolume) * (v - (double)meanVolume);
            }
            double varianceVolume = sum / volumeData.Count;
            double stdDev = Math.Sqrt(varianceVolume);

            // Normalize standard deviation by maximum volume in clip
            vstd = stdDev / (double)maxVolume;

            // Calculate ZCR standard deviation
            sum = 0;
            foreach (double z in zcrData)
            {
                sum += (z - (double)meanZcr) * (z - (double)meanZcr);
            }
            double varianceZcr = sum / zcrData.Count;
            zstd = Math.Sqrt(varianceZcr);
        }

        private void CalculateAv()
        {
            if (filePath == null) return;
            // Calculate average ZCR and STE for 1-second window
            using (WaveFileReader reader = new WaveFileReader(filePath))
            {
                ISampleProvider sampleProvider = reader.ToSampleProvider();
                List<double> zcrPerSecond = new List<double>();

                // One second window
                int windowSizeFloats = sampleProvider.WaveFormat.AverageBytesPerSecond / sizeof(float);
                float[] buffer = new float[windowSizeFloats];
                avZcr = 0;
                avSte = 0;
                int windowsCount = 0;
                while (true)
                {
                    int samplesRead = sampleProvider.Read(buffer, 0, windowSizeFloats);
                    if (samplesRead <= 0)
                        break;

                    // Calculate ZCR in window
                    double sum = 0;
                    for (int i = 1; i < samplesRead; i++)
                        sum += Math.Abs(Math.Sign(buffer[i]) - Math.Sign(buffer[i - 1]));
                    double value = sum * sampleProvider.WaveFormat.SampleRate / (2.0 * samplesRead);
                    avZcr += value;

                    // Calculate STE in window
                    sum = 0;
                    for (int i = 0; i < samplesRead; i++)
                        sum += buffer[i] * buffer[i];
                    value = sum / samplesRead;
                    avSte += value;

                    windowsCount++;
                }
                avZcr /= (double)windowsCount;
                avSte /= (double)windowsCount;
            }
        }

        private void CalculateHzcrr()
        {
            double sum = 0;
            foreach (double z in zcrData)
                sum += Math.Sign(z - 1.5f * avZcr) + 1;
            hzcrr = sum / (2.0 * zcrData.Count);
        }

        private void CalculateLster()
        {
            double sum = 0;
            foreach (double s in steData)
                sum += Math.Sign(0.5f * avSte - s) + 1;
            lster = sum / (2.0f * steData.Count);
        }

        private void buttonRepaint_Click(object sender, EventArgs e)
        {
            PaintCharts();
        }

        private void autocorInput_ValueChanged(object sender, EventArgs e)
        {
            autocorParam = (int)autocorInput.Value;
        }
    }
}
