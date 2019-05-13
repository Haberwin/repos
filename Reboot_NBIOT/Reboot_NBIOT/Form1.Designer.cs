namespace Reboot_NBIOT
{
    partial class Reboot_NBIoT
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
            this.BT_Start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lable_Com = new System.Windows.Forms.Label();
            this.SerialPort_IoT = new System.IO.Ports.SerialPort(this.components);
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.BT_Check_Port = new System.Windows.Forms.Button();
            this.BT_Close = new System.Windows.Forms.Button();
            this.ListBox_Com = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Start
            // 
            this.BT_Start.Location = new System.Drawing.Point(33, 216);
            this.BT_Start.Margin = new System.Windows.Forms.Padding(5);
            this.BT_Start.Name = "BT_Start";
            this.BT_Start.Size = new System.Drawing.Size(125, 66);
            this.BT_Start.TabIndex = 0;
            this.BT_Start.Text = "循环扫描";
            this.BT_Start.UseVisualStyleBackColor = true;
            this.BT_Start.Click += new System.EventHandler(this.BT_Start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBox_Com);
            this.groupBox1.Controls.Add(this.BT_Close);
            this.groupBox1.Controls.Add(this.BT_Check_Port);
            this.groupBox1.Controls.Add(this.BT_Start);
            this.groupBox1.Controls.Add(this.Lable_Com);
            this.groupBox1.Location = new System.Drawing.Point(14, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(441, 532);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // Lable_Com
            // 
            this.Lable_Com.Location = new System.Drawing.Point(29, 32);
            this.Lable_Com.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lable_Com.Name = "Lable_Com";
            this.Lable_Com.Size = new System.Drawing.Size(105, 33);
            this.Lable_Com.TabIndex = 0;
            this.Lable_Com.Text = "Port Name";
            this.Lable_Com.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SerialPort_IoT
            // 
            this.SerialPort_IoT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_IoT_DataReceived);
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(590, 39);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(380, 521);
            this.LogBox.TabIndex = 2;
            this.LogBox.Text = "";
            // 
            // BT_Check_Port
            // 
            this.BT_Check_Port.Location = new System.Drawing.Point(33, 116);
            this.BT_Check_Port.Name = "BT_Check_Port";
            this.BT_Check_Port.Size = new System.Drawing.Size(125, 31);
            this.BT_Check_Port.TabIndex = 3;
            this.BT_Check_Port.Text = "Check Port";
            this.BT_Check_Port.UseVisualStyleBackColor = true;
            this.BT_Check_Port.Click += new System.EventHandler(this.BT_Check_Port_Click);
            // 
            // BT_Close
            // 
            this.BT_Close.Location = new System.Drawing.Point(192, 116);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(138, 30);
            this.BT_Close.TabIndex = 4;
            this.BT_Close.Text = "Close Port";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // ListBox_Com
            // 
            this.ListBox_Com.FormattingEnabled = true;
            this.ListBox_Com.Location = new System.Drawing.Point(192, 32);
            this.ListBox_Com.Name = "ListBox_Com";
            this.ListBox_Com.Size = new System.Drawing.Size(138, 29);
            this.ListBox_Com.TabIndex = 5;
            // 
            // Reboot_NBIoT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 788);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Reboot_NBIoT";
            this.Text = "Reboot NBIOT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reboot_NBIoT_FormClosing);
            this.Load += new System.EventHandler(this.Reboot_NBIoT_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_Start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lable_Com;
        private System.IO.Ports.SerialPort SerialPort_IoT;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Button BT_Check_Port;
        private System.Windows.Forms.ComboBox ListBox_Com;
        private System.Windows.Forms.Button BT_Close;
    }
}

