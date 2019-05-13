namespace MCP_Test
{
    partial class MCP_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCP_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 4D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 112D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 157D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 78D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 87D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 198D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 256D);
            this.groupBox_Test = new System.Windows.Forms.GroupBox();
            this.OffTime = new System.Windows.Forms.NumericUpDown();
            this.TimeList = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cycles = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Current = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Voltage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.GetDevice = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Init_BT = new System.Windows.Forms.Button();
            this.Control_BT = new System.Windows.Forms.Button();
            this.button_scan = new System.Windows.Forms.Button();
            this.Device_Info = new System.Windows.Forms.Label();
            this.PowerSupply = new System.Windows.Forms.ListBox();
            this.label_devices = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCurrrent = new System.Windows.Forms.Label();
            this.RoundNum = new System.Windows.Forms.Label();
            this.timer_Test = new System.Windows.Forms.Timer(this.components);
            this.show_Vol = new System.Windows.Forms.CheckBox();
            this.show_Cur = new System.Windows.Forms.CheckBox();
            this.groupBox_Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OffTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cycles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Current)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltage)).BeginInit();
            this.GetDevice.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Test
            // 
            this.groupBox_Test.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_Test.Controls.Add(this.OffTime);
            this.groupBox_Test.Controls.Add(this.TimeList);
            this.groupBox_Test.Controls.Add(this.label5);
            this.groupBox_Test.Controls.Add(this.label4);
            this.groupBox_Test.Controls.Add(this.Cycles);
            this.groupBox_Test.Controls.Add(this.label3);
            this.groupBox_Test.Controls.Add(this.Current);
            this.groupBox_Test.Controls.Add(this.label2);
            this.groupBox_Test.Controls.Add(this.Voltage);
            this.groupBox_Test.Controls.Add(this.label1);
            this.groupBox_Test.Font = new System.Drawing.Font("Source Code Pro", 15.05455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Test.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox_Test.Location = new System.Drawing.Point(12, -1);
            this.groupBox_Test.Name = "groupBox_Test";
            this.groupBox_Test.Size = new System.Drawing.Size(672, 270);
            this.groupBox_Test.TabIndex = 4;
            this.groupBox_Test.TabStop = false;
            this.groupBox_Test.Text = "Setting";
            // 
            // OffTime
            // 
            this.OffTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OffTime.Font = new System.Drawing.Font("Source Code Pro", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffTime.Location = new System.Drawing.Point(483, 190);
            this.OffTime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.OffTime.Name = "OffTime";
            this.OffTime.Size = new System.Drawing.Size(160, 34);
            this.OffTime.TabIndex = 14;
            this.OffTime.ThousandsSeparator = true;
            this.OffTime.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.OffTime.ValueChanged += new System.EventHandler(this.OffTime_ValueChanged);
            // 
            // TimeList
            // 
            this.TimeList.Font = new System.Drawing.Font("Source Code Pro", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeList.Location = new System.Drawing.Point(34, 190);
            this.TimeList.Name = "TimeList";
            this.TimeList.Size = new System.Drawing.Size(391, 34);
            this.TimeList.TabIndex = 13;
            this.TimeList.Text = "1,2,5,8,11,15,20,30,40,50,60";
            this.TimeList.TextChanged += new System.EventHandler(this.TimeList_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Source Code Pro", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(470, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 27);
            this.label5.TabIndex = 12;
            this.label5.Text = "Off Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Source Code Pro", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(33, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = "On Time";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cycles
            // 
            this.Cycles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cycles.Location = new System.Drawing.Point(483, 90);
            this.Cycles.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Cycles.Name = "Cycles";
            this.Cycles.Size = new System.Drawing.Size(160, 36);
            this.Cycles.TabIndex = 9;
            this.Cycles.ThousandsSeparator = true;
            this.Cycles.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Cycles.ValueChanged += new System.EventHandler(this.Cycles_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Source Code Pro", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cycles";
            // 
            // Current
            // 
            this.Current.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Current.DecimalPlaces = 2;
            this.Current.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Current.Location = new System.Drawing.Point(265, 90);
            this.Current.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(160, 36);
            this.Current.TabIndex = 7;
            this.Current.Value = new decimal(new int[] {
            300,
            0,
            0,
            131072});
            this.Current.ValueChanged += new System.EventHandler(this.Current_ValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Source Code Pro", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Limit";
            // 
            // Voltage
            // 
            this.Voltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Voltage.DecimalPlaces = 2;
            this.Voltage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Voltage.Location = new System.Drawing.Point(34, 90);
            this.Voltage.Name = "Voltage";
            this.Voltage.Size = new System.Drawing.Size(179, 36);
            this.Voltage.TabIndex = 5;
            this.Voltage.Value = new decimal(new int[] {
            400,
            0,
            0,
            131072});
            this.Voltage.ValueChanged += new System.EventHandler(this.Voltage_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Voltage Setting";
            // 
            // GetDevice
            // 
            this.GetDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GetDevice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GetDevice.Controls.Add(this.panel1);
            this.GetDevice.Controls.Add(this.Device_Info);
            this.GetDevice.Controls.Add(this.PowerSupply);
            this.GetDevice.Controls.Add(this.label_devices);
            this.GetDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetDevice.Font = new System.Drawing.Font("Source Code Pro", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDevice.ForeColor = System.Drawing.SystemColors.Window;
            this.GetDevice.Location = new System.Drawing.Point(690, -1);
            this.GetDevice.Name = "GetDevice";
            this.GetDevice.Size = new System.Drawing.Size(716, 270);
            this.GetDevice.TabIndex = 3;
            this.GetDevice.TabStop = false;
            this.GetDevice.Text = "Initialize";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Init_BT);
            this.panel1.Controls.Add(this.Control_BT);
            this.panel1.Controls.Add(this.button_scan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 136);
            this.panel1.TabIndex = 4;
            // 
            // Init_BT
            // 
            this.Init_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Init_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Init_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Init_BT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Init_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Init_BT.Font = new System.Drawing.Font("Source Code Pro", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Init_BT.ForeColor = System.Drawing.Color.Coral;
            this.Init_BT.Image = ((System.Drawing.Image)(resources.GetObject("Init_BT.Image")));
            this.Init_BT.Location = new System.Drawing.Point(158, 0);
            this.Init_BT.Name = "Init_BT";
            this.Init_BT.Size = new System.Drawing.Size(341, 136);
            this.Init_BT.TabIndex = 2;
            this.Init_BT.Text = "Initlialize";
            this.Init_BT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Init_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Init_BT.UseVisualStyleBackColor = false;
            this.Init_BT.Click += new System.EventHandler(this.Init_BT_Click);
            // 
            // Control_BT
            // 
            this.Control_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Control_BT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Control_BT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Control_BT.Dock = System.Windows.Forms.DockStyle.Right;
            this.Control_BT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Control_BT.Font = new System.Drawing.Font("Source Code Pro", 15.05455F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control_BT.ForeColor = System.Drawing.Color.GreenYellow;
            this.Control_BT.Image = global::MCP_Test.Properties.Resources.Start;
            this.Control_BT.Location = new System.Drawing.Point(499, 0);
            this.Control_BT.Name = "Control_BT";
            this.Control_BT.Size = new System.Drawing.Size(211, 136);
            this.Control_BT.TabIndex = 1;
            this.Control_BT.Text = "Start";
            this.Control_BT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Control_BT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Control_BT.UseVisualStyleBackColor = false;
            this.Control_BT.Click += new System.EventHandler(this.Control_BT_Click);
            // 
            // button_scan
            // 
            this.button_scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_scan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_scan.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_scan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_scan.Font = new System.Drawing.Font("Consolas", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scan.ForeColor = System.Drawing.Color.DarkOrange;
            this.button_scan.Image = global::MCP_Test.Properties.Resources.Scan3;
            this.button_scan.Location = new System.Drawing.Point(0, 0);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(158, 136);
            this.button_scan.TabIndex = 0;
            this.button_scan.Text = "Scan";
            this.button_scan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_scan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_scan.UseVisualStyleBackColor = false;
            this.button_scan.Click += new System.EventHandler(this.Button_scan_Click);
            // 
            // Device_Info
            // 
            this.Device_Info.BackColor = System.Drawing.Color.Black;
            this.Device_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.Device_Info.Font = new System.Drawing.Font("Source Code Pro", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Device_Info.ForeColor = System.Drawing.SystemColors.Window;
            this.Device_Info.Location = new System.Drawing.Point(3, 100);
            this.Device_Info.Name = "Device_Info";
            this.Device_Info.Size = new System.Drawing.Size(710, 34);
            this.Device_Info.TabIndex = 3;
            this.Device_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PowerSupply
            // 
            this.PowerSupply.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PowerSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.PowerSupply.Font = new System.Drawing.Font("Source Code Pro", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerSupply.ForeColor = System.Drawing.SystemColors.MenuText;
            this.PowerSupply.FormattingEnabled = true;
            this.PowerSupply.ItemHeight = 23;
            this.PowerSupply.Location = new System.Drawing.Point(3, 73);
            this.PowerSupply.Name = "PowerSupply";
            this.PowerSupply.ScrollAlwaysVisible = true;
            this.PowerSupply.Size = new System.Drawing.Size(710, 27);
            this.PowerSupply.TabIndex = 2;
            this.PowerSupply.SelectedIndexChanged += new System.EventHandler(this.List_devices_SelectedIndexChanged);
            // 
            // label_devices
            // 
            this.label_devices.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_devices.Font = new System.Drawing.Font("Source Code Pro", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_devices.ForeColor = System.Drawing.SystemColors.Window;
            this.label_devices.Location = new System.Drawing.Point(3, 26);
            this.label_devices.Name = "label_devices";
            this.label_devices.Size = new System.Drawing.Size(710, 47);
            this.label_devices.TabIndex = 1;
            this.label_devices.Text = "PowerSupply Type";
            this.label_devices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.Title = "时间(s)";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea1.AxisY.Title = "电流(mA)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MajorTickMark.IntervalOffset = 0D;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.Title = "电压(v)";
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Far;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 275);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Voltage";
            dataPoint1.Label = "";
            dataPoint2.Label = "";
            dataPoint3.Label = "";
            dataPoint4.Label = "";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.OrangeRed;
            series2.Legend = "Legend1";
            series2.Name = "Current";
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series2.Points.Add(dataPoint11);
            series2.Points.Add(dataPoint12);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1394, 468);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // labelCurrrent
            // 
            this.labelCurrrent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrrent.BackColor = System.Drawing.Color.White;
            this.labelCurrrent.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelCurrrent.Location = new System.Drawing.Point(688, 284);
            this.labelCurrrent.Name = "labelCurrrent";
            this.labelCurrrent.Size = new System.Drawing.Size(137, 28);
            this.labelCurrrent.TabIndex = 6;
            this.labelCurrrent.Text = "0 mA";
            this.labelCurrrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoundNum
            // 
            this.RoundNum.BackColor = System.Drawing.Color.White;
            this.RoundNum.Font = new System.Drawing.Font("Source Code Pro", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundNum.ForeColor = System.Drawing.Color.Magenta;
            this.RoundNum.Location = new System.Drawing.Point(45, 284);
            this.RoundNum.Name = "RoundNum";
            this.RoundNum.Size = new System.Drawing.Size(184, 28);
            this.RoundNum.TabIndex = 13;
            this.RoundNum.Text = "Round 0";
            this.RoundNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RoundNum.DoubleClick += new System.EventHandler(this.RoundNum_DoubleClick);
            // 
            // timer_Test
            // 
            this.timer_Test.Interval = 1000;
            this.timer_Test.Tick += new System.EventHandler(this.Timer_Test_Tick);
            // 
            // show_Vol
            // 
            this.show_Vol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.show_Vol.AutoSize = true;
            this.show_Vol.Checked = true;
            this.show_Vol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.show_Vol.Font = new System.Drawing.Font("微软雅黑", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.show_Vol.Location = new System.Drawing.Point(1364, 294);
            this.show_Vol.Name = "show_Vol";
            this.show_Vol.Size = new System.Drawing.Size(15, 14);
            this.show_Vol.TabIndex = 14;
            this.show_Vol.UseVisualStyleBackColor = true;
            this.show_Vol.CheckedChanged += new System.EventHandler(this.Show_Vol_CheckedChanged);
            // 
            // show_Cur
            // 
            this.show_Cur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.show_Cur.AutoSize = true;
            this.show_Cur.Checked = true;
            this.show_Cur.CheckState = System.Windows.Forms.CheckState.Checked;
            this.show_Cur.Font = new System.Drawing.Font("微软雅黑", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.show_Cur.Location = new System.Drawing.Point(1364, 314);
            this.show_Cur.Name = "show_Cur";
            this.show_Cur.Size = new System.Drawing.Size(15, 14);
            this.show_Cur.TabIndex = 15;
            this.show_Cur.UseVisualStyleBackColor = true;
            this.show_Cur.CheckedChanged += new System.EventHandler(this.Show_Cur_CheckedChanged);
            // 
            // MCP_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1418, 755);
            this.Controls.Add(this.show_Cur);
            this.Controls.Add(this.show_Vol);
            this.Controls.Add(this.RoundNum);
            this.Controls.Add(this.labelCurrrent);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox_Test);
            this.Controls.Add(this.GetDevice);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MCP_Form";
            this.Text = "MCP Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MCP_Form_FormClosing);
            this.Shown += new System.EventHandler(this.MCP_Form_Shown);
            this.groupBox_Test.ResumeLayout(false);
            this.groupBox_Test.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OffTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cycles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Current)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voltage)).EndInit();
            this.GetDevice.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_Test;
        private System.Windows.Forms.GroupBox GetDevice;
        private System.Windows.Forms.Label Device_Info;
        private System.Windows.Forms.ListBox PowerSupply;
        private System.Windows.Forms.Label label_devices;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.NumericUpDown Cycles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Current;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Voltage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelCurrrent;
        private System.Windows.Forms.Button Control_BT;
        private System.Windows.Forms.Button Init_BT;
        private System.Windows.Forms.Label RoundNum;
        private System.Windows.Forms.NumericUpDown OffTime;
        private System.Windows.Forms.TextBox TimeList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer_Test;
        private System.Windows.Forms.CheckBox show_Vol;
        private System.Windows.Forms.CheckBox show_Cur;
    }
}

