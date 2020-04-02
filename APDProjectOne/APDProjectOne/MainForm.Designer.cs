namespace APDProjectOne
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waveViewer = new NAudio.Gui.WaveViewer();
            this.fileLabel = new System.Windows.Forms.Label();
            this.volumeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.srChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.zcrChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.steChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.zcrLabel = new System.Windows.Forms.Label();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.steLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.srLabel = new System.Windows.Forms.Label();
            this.msLabel = new System.Windows.Forms.Label();
            this.msInput = new System.Windows.Forms.NumericUpDown();
            this.buttonRepaint = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.hzcrrLabel = new System.Windows.Forms.Label();
            this.lsterLabel = new System.Windows.Forms.Label();
            this.vdrLabel = new System.Windows.Forms.Label();
            this.vstdLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeChart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zcrChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msInput)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Audio files (*.wav;)|*.wav";
            this.openFileDialog.Title = "Open audio file";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1384, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenFileClick);
            // 
            // waveViewer
            // 
            this.waveViewer.AutoSize = true;
            this.waveViewer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.waveViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waveViewer.Location = new System.Drawing.Point(12, 54);
            this.waveViewer.Name = "waveViewer";
            this.waveViewer.SamplesPerPixel = 128;
            this.waveViewer.Size = new System.Drawing.Size(1360, 97);
            this.waveViewer.StartPosition = ((long)(0));
            this.waveViewer.TabIndex = 3;
            this.waveViewer.WaveStream = null;
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(286, 30);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(73, 13);
            this.fileLabel.TabIndex = 4;
            this.fileLabel.Text = "No file open...";
            // 
            // volumeChart
            // 
            chartArea5.AxisX.LabelStyle.Enabled = false;
            chartArea5.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.MajorTickMark.Enabled = false;
            chartArea5.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX2.MajorGrid.Enabled = false;
            chartArea5.AxisX2.MajorTickMark.Enabled = false;
            chartArea5.AxisY.LabelStyle.Enabled = false;
            chartArea5.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.MajorGrid.Enabled = false;
            chartArea5.AxisY.MajorTickMark.Enabled = false;
            chartArea5.AxisY2.LabelStyle.Enabled = false;
            chartArea5.AxisY2.MajorGrid.Enabled = false;
            chartArea5.AxisY2.MajorTickMark.Enabled = false;
            chartArea5.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea5.Name = "ChartArea1";
            this.volumeChart.ChartAreas.Add(chartArea5);
            this.volumeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Enabled = false;
            legend5.Name = "Legend1";
            this.volumeChart.Legends.Add(legend5);
            this.volumeChart.Location = new System.Drawing.Point(168, 3);
            this.volumeChart.Name = "volumeChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.volumeChart.Series.Add(series5);
            this.volumeChart.Size = new System.Drawing.Size(1189, 43);
            this.volumeChart.TabIndex = 8;
            this.volumeChart.Text = "volumeChart";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.19891F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.80109F));
            this.tableLayoutPanel1.Controls.Add(this.srChart, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.zcrChart, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.steChart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.zcrLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.volumeChart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.volumeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.steLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.srLabel, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 157);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1360, 349);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // srChart
            // 
            chartArea6.AxisX.LabelStyle.Enabled = false;
            chartArea6.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.MajorTickMark.Enabled = false;
            chartArea6.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisX2.MajorGrid.Enabled = false;
            chartArea6.AxisX2.MajorTickMark.Enabled = false;
            chartArea6.AxisY.LabelStyle.Enabled = false;
            chartArea6.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.AxisY.MajorTickMark.Enabled = false;
            chartArea6.AxisY2.LabelStyle.Enabled = false;
            chartArea6.AxisY2.MajorGrid.Enabled = false;
            chartArea6.AxisY2.MajorTickMark.Enabled = false;
            chartArea6.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea6.Name = "ChartArea1";
            this.srChart.ChartAreas.Add(chartArea6);
            this.srChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Enabled = false;
            legend6.Name = "Legend1";
            this.srChart.Legends.Add(legend6);
            this.srChart.Location = new System.Drawing.Point(168, 150);
            this.srChart.Name = "srChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.srChart.Series.Add(series6);
            this.srChart.Size = new System.Drawing.Size(1189, 43);
            this.srChart.TabIndex = 18;
            this.srChart.Text = "srChart";
            // 
            // zcrChart
            // 
            chartArea7.AxisX.LabelStyle.Enabled = false;
            chartArea7.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX.MajorGrid.Enabled = false;
            chartArea7.AxisX.MajorTickMark.Enabled = false;
            chartArea7.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisX2.MajorGrid.Enabled = false;
            chartArea7.AxisX2.MajorTickMark.Enabled = false;
            chartArea7.AxisY.LabelStyle.Enabled = false;
            chartArea7.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea7.AxisY.MajorGrid.Enabled = false;
            chartArea7.AxisY.MajorTickMark.Enabled = false;
            chartArea7.AxisY2.LabelStyle.Enabled = false;
            chartArea7.AxisY2.MajorGrid.Enabled = false;
            chartArea7.AxisY2.MajorTickMark.Enabled = false;
            chartArea7.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea7.Name = "ChartArea1";
            this.zcrChart.ChartAreas.Add(chartArea7);
            this.zcrChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend7.Enabled = false;
            legend7.Name = "Legend1";
            this.zcrChart.Legends.Add(legend7);
            this.zcrChart.Location = new System.Drawing.Point(168, 101);
            this.zcrChart.Name = "zcrChart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.zcrChart.Series.Add(series7);
            this.zcrChart.Size = new System.Drawing.Size(1189, 43);
            this.zcrChart.TabIndex = 17;
            this.zcrChart.Text = "zcrChart";
            // 
            // steChart
            // 
            chartArea8.AxisX.LabelStyle.Enabled = false;
            chartArea8.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX.MajorGrid.Enabled = false;
            chartArea8.AxisX.MajorTickMark.Enabled = false;
            chartArea8.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea8.AxisX2.MajorGrid.Enabled = false;
            chartArea8.AxisX2.MajorTickMark.Enabled = false;
            chartArea8.AxisY.LabelStyle.Enabled = false;
            chartArea8.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea8.AxisY.MajorGrid.Enabled = false;
            chartArea8.AxisY.MajorTickMark.Enabled = false;
            chartArea8.AxisY2.LabelStyle.Enabled = false;
            chartArea8.AxisY2.MajorGrid.Enabled = false;
            chartArea8.AxisY2.MajorTickMark.Enabled = false;
            chartArea8.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea8.Name = "ChartArea1";
            this.steChart.ChartAreas.Add(chartArea8);
            this.steChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend8.Enabled = false;
            legend8.Name = "Legend1";
            this.steChart.Legends.Add(legend8);
            this.steChart.Location = new System.Drawing.Point(168, 52);
            this.steChart.Name = "steChart";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.steChart.Series.Add(series8);
            this.steChart.Size = new System.Drawing.Size(1189, 43);
            this.steChart.TabIndex = 16;
            this.steChart.Text = "steChart";
            // 
            // zcrLabel
            // 
            this.zcrLabel.AutoSize = true;
            this.zcrLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zcrLabel.Location = new System.Drawing.Point(3, 98);
            this.zcrLabel.Name = "zcrLabel";
            this.zcrLabel.Size = new System.Drawing.Size(159, 49);
            this.zcrLabel.TabIndex = 12;
            this.zcrLabel.Text = "ZCR";
            this.zcrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumeLabel.Location = new System.Drawing.Point(3, 0);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(159, 49);
            this.volumeLabel.TabIndex = 9;
            this.volumeLabel.Text = "Volume";
            this.volumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // steLabel
            // 
            this.steLabel.AutoSize = true;
            this.steLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steLabel.Location = new System.Drawing.Point(3, 49);
            this.steLabel.Name = "steLabel";
            this.steLabel.Size = new System.Drawing.Size(159, 49);
            this.steLabel.TabIndex = 10;
            this.steLabel.Text = "STE";
            this.steLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 55);
            this.label7.TabIndex = 15;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 49);
            this.label6.TabIndex = 14;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 49);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srLabel
            // 
            this.srLabel.AutoSize = true;
            this.srLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srLabel.Location = new System.Drawing.Point(3, 147);
            this.srLabel.Name = "srLabel";
            this.srLabel.Size = new System.Drawing.Size(159, 49);
            this.srLabel.TabIndex = 11;
            this.srLabel.Text = "SR";
            this.srLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Location = new System.Drawing.Point(13, 30);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(60, 13);
            this.msLabel.TabIndex = 10;
            this.msLabel.Text = "ms / frame:";
            // 
            // msInput
            // 
            this.msInput.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.msInput.Location = new System.Drawing.Point(79, 28);
            this.msInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.msInput.Name = "msInput";
            this.msInput.Size = new System.Drawing.Size(120, 20);
            this.msInput.TabIndex = 11;
            this.msInput.ValueChanged += new System.EventHandler(this.msInput_ValueChanged);
            // 
            // buttonRepaint
            // 
            this.buttonRepaint.Location = new System.Drawing.Point(205, 25);
            this.buttonRepaint.Name = "buttonRepaint";
            this.buttonRepaint.Size = new System.Drawing.Size(75, 23);
            this.buttonRepaint.TabIndex = 12;
            this.buttonRepaint.Text = "Repaint";
            this.buttonRepaint.UseVisualStyleBackColor = true;
            this.buttonRepaint.Click += new System.EventHandler(this.buttonRepaint_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.hzcrrLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lsterLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.vdrLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.vstdLabel, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 512);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1359, 37);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // hzcrrLabel
            // 
            this.hzcrrLabel.AutoSize = true;
            this.hzcrrLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hzcrrLabel.Location = new System.Drawing.Point(1020, 0);
            this.hzcrrLabel.Name = "hzcrrLabel";
            this.hzcrrLabel.Size = new System.Drawing.Size(336, 37);
            this.hzcrrLabel.TabIndex = 3;
            this.hzcrrLabel.Text = "HZCRR: 0";
            this.hzcrrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsterLabel
            // 
            this.lsterLabel.AutoSize = true;
            this.lsterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsterLabel.Location = new System.Drawing.Point(681, 0);
            this.lsterLabel.Name = "lsterLabel";
            this.lsterLabel.Size = new System.Drawing.Size(333, 37);
            this.lsterLabel.TabIndex = 2;
            this.lsterLabel.Text = "LSTER: 0";
            this.lsterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vdrLabel
            // 
            this.vdrLabel.AutoSize = true;
            this.vdrLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vdrLabel.Location = new System.Drawing.Point(342, 0);
            this.vdrLabel.Name = "vdrLabel";
            this.vdrLabel.Size = new System.Drawing.Size(333, 37);
            this.vdrLabel.TabIndex = 1;
            this.vdrLabel.Text = "VDR: 0";
            this.vdrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vstdLabel
            // 
            this.vstdLabel.AutoSize = true;
            this.vstdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vstdLabel.Location = new System.Drawing.Point(3, 0);
            this.vstdLabel.Name = "vstdLabel";
            this.vstdLabel.Size = new System.Drawing.Size(333, 37);
            this.vstdLabel.TabIndex = 0;
            this.vstdLabel.Text = "VSTD: 0";
            this.vstdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1384, 561);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.buttonRepaint);
            this.Controls.Add(this.msInput);
            this.Controls.Add(this.msLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.waveViewer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1400, 600);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zcrChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msInput)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private NAudio.Gui.WaveViewer waveViewer;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart volumeChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Label zcrLabel;
        private System.Windows.Forms.Label steLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label srLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart srChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart zcrChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart steChart;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.NumericUpDown msInput;
        private System.Windows.Forms.Button buttonRepaint;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label hzcrrLabel;
        private System.Windows.Forms.Label lsterLabel;
        private System.Windows.Forms.Label vdrLabel;
        private System.Windows.Forms.Label vstdLabel;
    }
}

