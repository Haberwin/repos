namespace RTC_Test
{
    partial class RTC_Form
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
            this.GetDevice = new System.Windows.Forms.GroupBox();
            this.Device_Info = new System.Windows.Forms.Label();
            this.list_devices = new System.Windows.Forms.ListBox();
            this.label_devices = new System.Windows.Forms.Label();
            this.button_scan = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.groupBox_Test = new System.Windows.Forms.GroupBox();
            this.Label_Barcode = new System.Windows.Forms.Label();
            this.TextBox_Barcode = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.Current = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.label_Max = new System.Windows.Forms.Label();
            this.label_Current = new System.Windows.Forms.Label();
            this.label_min = new System.Windows.Forms.Label();
            this.GetDevice.SuspendLayout();
            this.groupBox_Test.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetDevice
            // 
            this.GetDevice.Controls.Add(this.Device_Info);
            this.GetDevice.Controls.Add(this.list_devices);
            this.GetDevice.Controls.Add(this.label_devices);
            this.GetDevice.Controls.Add(this.button_scan);
            this.GetDevice.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetDevice.Location = new System.Drawing.Point(47, 375);
            this.GetDevice.Name = "GetDevice";
            this.GetDevice.Size = new System.Drawing.Size(694, 223);
            this.GetDevice.TabIndex = 2;
            this.GetDevice.TabStop = false;
            this.GetDevice.Text = "Get GPIB Device";
            // 
            // Device_Info
            // 
            this.Device_Info.BackColor = System.Drawing.Color.GreenYellow;
            this.Device_Info.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Device_Info.Location = new System.Drawing.Point(26, 146);
            this.Device_Info.Name = "Device_Info";
            this.Device_Info.Size = new System.Drawing.Size(644, 54);
            this.Device_Info.TabIndex = 3;
            this.Device_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // list_devices
            // 
            this.list_devices.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.list_devices.FormattingEnabled = true;
            this.list_devices.ItemHeight = 31;
            this.list_devices.Location = new System.Drawing.Point(31, 80);
            this.list_devices.Name = "list_devices";
            this.list_devices.Size = new System.Drawing.Size(478, 35);
            this.list_devices.TabIndex = 2;
            this.list_devices.SelectedIndexChanged += new System.EventHandler(this.List_devices_SelectedIndexChanged);
            // 
            // label_devices
            // 
            this.label_devices.AutoSize = true;
            this.label_devices.Location = new System.Drawing.Point(26, 38);
            this.label_devices.Name = "label_devices";
            this.label_devices.Size = new System.Drawing.Size(132, 30);
            this.label_devices.TabIndex = 1;
            this.label_devices.Text = "Device List";
            // 
            // button_scan
            // 
            this.button_scan.AutoSize = true;
            this.button_scan.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_scan.Location = new System.Drawing.Point(542, 38);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(133, 91);
            this.button_scan.TabIndex = 0;
            this.button_scan.Text = "Scan";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.Button_scan_Click);
            // 
            // Log
            // 
            this.Log.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Log.Location = new System.Drawing.Point(767, 28);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(334, 570);
            this.Log.TabIndex = 3;
            // 
            // groupBox_Test
            // 
            this.groupBox_Test.Controls.Add(this.Label_Barcode);
            this.groupBox_Test.Controls.Add(this.TextBox_Barcode);
            this.groupBox_Test.Controls.Add(this.Result);
            this.groupBox_Test.Controls.Add(this.label2);
            this.groupBox_Test.Controls.Add(this.label1);
            this.groupBox_Test.Controls.Add(this.Max);
            this.groupBox_Test.Controls.Add(this.Current);
            this.groupBox_Test.Controls.Add(this.Min);
            this.groupBox_Test.Controls.Add(this.label_Max);
            this.groupBox_Test.Controls.Add(this.label_Current);
            this.groupBox_Test.Controls.Add(this.label_min);
            this.groupBox_Test.Location = new System.Drawing.Point(47, 28);
            this.groupBox_Test.Name = "groupBox_Test";
            this.groupBox_Test.Size = new System.Drawing.Size(694, 341);
            this.groupBox_Test.TabIndex = 4;
            this.groupBox_Test.TabStop = false;
            this.groupBox_Test.Text = "Test";
            // 
            // Label_Barcode
            // 
            this.Label_Barcode.AutoSize = true;
            this.Label_Barcode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Barcode.Location = new System.Drawing.Point(26, 61);
            this.Label_Barcode.Name = "Label_Barcode";
            this.Label_Barcode.Size = new System.Drawing.Size(105, 30);
            this.Label_Barcode.TabIndex = 11;
            this.Label_Barcode.Text = "机器条码";
            // 
            // TextBox_Barcode
            // 
            this.TextBox_Barcode.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_Barcode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TextBox_Barcode.Location = new System.Drawing.Point(185, 54);
            this.TextBox_Barcode.Name = "TextBox_Barcode";
            this.TextBox_Barcode.Size = new System.Drawing.Size(349, 38);
            this.TextBox_Barcode.TabIndex = 10;
            this.TextBox_Barcode.TextChanged += new System.EventHandler(this.TextBox_Barcode_TextChanged);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.White;
            this.Result.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Result.Location = new System.Drawing.Point(28, 237);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(651, 73);
            this.Result.TabIndex = 9;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(384, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "<=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(189, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "<=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Max
            // 
            this.Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Max.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Max.Location = new System.Drawing.Point(444, 185);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(150, 40);
            this.Max.TabIndex = 5;
            this.Max.Text = "3.40";
            this.Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Current
            // 
            this.Current.BackColor = System.Drawing.Color.White;
            this.Current.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Current.Location = new System.Drawing.Point(239, 185);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(150, 40);
            this.Current.TabIndex = 4;
            this.Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Current.TextChanged += new System.EventHandler(this.Current_TextChanged);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Min.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Min.Location = new System.Drawing.Point(29, 185);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(150, 40);
            this.Min.TabIndex = 3;
            this.Min.Text = "2.50";
            this.Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Max
            // 
            this.label_Max.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Max.Location = new System.Drawing.Point(444, 128);
            this.label_Max.Name = "label_Max";
            this.label_Max.Size = new System.Drawing.Size(150, 40);
            this.label_Max.TabIndex = 2;
            this.label_Max.Text = "Max(v)";
            this.label_Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Current
            // 
            this.label_Current.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Current.Location = new System.Drawing.Point(239, 128);
            this.label_Current.Name = "label_Current";
            this.label_Current.Size = new System.Drawing.Size(150, 40);
            this.label_Current.TabIndex = 1;
            this.label_Current.Text = "Current(v)";
            this.label_Current.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_min
            // 
            this.label_min.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_min.Location = new System.Drawing.Point(29, 128);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(150, 40);
            this.label_min.TabIndex = 0;
            this.label_min.Text = "Min(v)";
            this.label_min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RTC_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 610);
            this.Controls.Add(this.groupBox_Test);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.GetDevice);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RTC_Form";
            this.Text = "RTC Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RTC_Form_FormClosing);
            this.Shown += new System.EventHandler(this.RTC_Form_Shown);
            this.GetDevice.ResumeLayout(false);
            this.GetDevice.PerformLayout();
            this.groupBox_Test.ResumeLayout(false);
            this.groupBox_Test.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GetDevice;
        private System.Windows.Forms.ListBox list_devices;
        private System.Windows.Forms.Label label_devices;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.TextBox Log;
        private System.Windows.Forms.GroupBox groupBox_Test;
        private System.Windows.Forms.Label Device_Info;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Max;
        private System.Windows.Forms.Label Current;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label label_Max;
        private System.Windows.Forms.Label label_Current;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label Label_Barcode;
        private System.Windows.Forms.TextBox TextBox_Barcode;
    }
}

