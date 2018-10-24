namespace NBIoT
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Address = new System.Windows.Forms.GroupBox();
            this.IP = new System.Windows.Forms.TextBox();
            this.GPIB = new System.Windows.Forms.TextBox();
            this.ISIP = new System.Windows.Forms.RadioButton();
            this.IsGPIB = new System.Windows.Forms.RadioButton();
            this.Port = new System.Windows.Forms.GroupBox();
            this.label_Att = new System.Windows.Forms.Label();
            this.RX_Port = new System.Windows.Forms.ComboBox();
            this.TX_Port = new System.Windows.Forms.ComboBox();
            this.RX_ATT = new System.Windows.Forms.TextBox();
            this.TX_ATT = new System.Windows.Forms.TextBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.label_RX = new System.Windows.Forms.Label();
            this.label_TX = new System.Windows.Forms.Label();
            this.Button_TestConnect = new System.Windows.Forms.Button();
            this.CMW_Info = new System.Windows.Forms.Label();
            this.List_Item = new System.Windows.Forms.CheckedListBox();
            this.GPIB_Index = new System.Windows.Forms.ComboBox();
            this.label_Index = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.Address.SuspendLayout();
            this.Port.SuspendLayout();
            this.SuspendLayout();
            // 
            // Address
            // 
            this.Address.Controls.Add(this.label_Address);
            this.Address.Controls.Add(this.label_Index);
            this.Address.Controls.Add(this.GPIB_Index);
            this.Address.Controls.Add(this.IP);
            this.Address.Controls.Add(this.GPIB);
            this.Address.Controls.Add(this.ISIP);
            this.Address.Controls.Add(this.IsGPIB);
            this.Address.Location = new System.Drawing.Point(12, 31);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(317, 191);
            this.Address.TabIndex = 0;
            this.Address.TabStop = false;
            this.Address.Text = "CMW_Address";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(162, 103);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(131, 26);
            this.IP.TabIndex = 3;
            // 
            // GPIB
            // 
            this.GPIB.Location = new System.Drawing.Point(213, 61);
            this.GPIB.Name = "GPIB";
            this.GPIB.Size = new System.Drawing.Size(80, 26);
            this.GPIB.TabIndex = 2;
            // 
            // ISIP
            // 
            this.ISIP.AutoSize = true;
            this.ISIP.Location = new System.Drawing.Point(15, 105);
            this.ISIP.Name = "ISIP";
            this.ISIP.Size = new System.Drawing.Size(40, 24);
            this.ISIP.TabIndex = 1;
            this.ISIP.TabStop = true;
            this.ISIP.Text = "IP";
            this.ISIP.UseVisualStyleBackColor = true;
            // 
            // IsGPIB
            // 
            this.IsGPIB.AutoSize = true;
            this.IsGPIB.Location = new System.Drawing.Point(15, 60);
            this.IsGPIB.Name = "IsGPIB";
            this.IsGPIB.Size = new System.Drawing.Size(59, 24);
            this.IsGPIB.TabIndex = 0;
            this.IsGPIB.TabStop = true;
            this.IsGPIB.Text = "GPIB";
            this.IsGPIB.UseVisualStyleBackColor = true;
            // 
            // Port
            // 
            this.Port.Controls.Add(this.label_Att);
            this.Port.Controls.Add(this.RX_Port);
            this.Port.Controls.Add(this.TX_Port);
            this.Port.Controls.Add(this.RX_ATT);
            this.Port.Controls.Add(this.TX_ATT);
            this.Port.Controls.Add(this.label_Port);
            this.Port.Controls.Add(this.label_RX);
            this.Port.Controls.Add(this.label_TX);
            this.Port.Location = new System.Drawing.Point(443, 31);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(448, 191);
            this.Port.TabIndex = 1;
            this.Port.TabStop = false;
            this.Port.Text = "Port";
            // 
            // label_Att
            // 
            this.label_Att.AutoSize = true;
            this.label_Att.Location = new System.Drawing.Point(249, 22);
            this.label_Att.Name = "label_Att";
            this.label_Att.Size = new System.Drawing.Size(90, 20);
            this.label_Att.TabIndex = 7;
            this.label_Att.Text = "Attenuation";
            // 
            // RX_Port
            // 
            this.RX_Port.FormattingEnabled = true;
            this.RX_Port.Location = new System.Drawing.Point(110, 101);
            this.RX_Port.Name = "RX_Port";
            this.RX_Port.Size = new System.Drawing.Size(101, 28);
            this.RX_Port.TabIndex = 6;
            // 
            // TX_Port
            // 
            this.TX_Port.FormattingEnabled = true;
            this.TX_Port.Location = new System.Drawing.Point(110, 58);
            this.TX_Port.Name = "TX_Port";
            this.TX_Port.Size = new System.Drawing.Size(101, 28);
            this.TX_Port.TabIndex = 5;
            // 
            // RX_ATT
            // 
            this.RX_ATT.Location = new System.Drawing.Point(253, 104);
            this.RX_ATT.Name = "RX_ATT";
            this.RX_ATT.Size = new System.Drawing.Size(131, 26);
            this.RX_ATT.TabIndex = 4;
            // 
            // TX_ATT
            // 
            this.TX_ATT.Location = new System.Drawing.Point(253, 61);
            this.TX_ATT.Name = "TX_ATT";
            this.TX_ATT.Size = new System.Drawing.Size(131, 26);
            this.TX_ATT.TabIndex = 3;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(106, 22);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(37, 20);
            this.label_Port.TabIndex = 2;
            this.label_Port.Text = "Port";
            // 
            // label_RX
            // 
            this.label_RX.AutoSize = true;
            this.label_RX.Location = new System.Drawing.Point(34, 107);
            this.label_RX.Name = "label_RX";
            this.label_RX.Size = new System.Drawing.Size(27, 20);
            this.label_RX.TabIndex = 1;
            this.label_RX.Text = "RX";
            // 
            // label_TX
            // 
            this.label_TX.AutoSize = true;
            this.label_TX.Location = new System.Drawing.Point(35, 64);
            this.label_TX.Name = "label_TX";
            this.label_TX.Size = new System.Drawing.Size(26, 20);
            this.label_TX.TabIndex = 0;
            this.label_TX.Text = "TX";
            // 
            // Button_TestConnect
            // 
            this.Button_TestConnect.Location = new System.Drawing.Point(12, 242);
            this.Button_TestConnect.Name = "Button_TestConnect";
            this.Button_TestConnect.Size = new System.Drawing.Size(132, 36);
            this.Button_TestConnect.TabIndex = 2;
            this.Button_TestConnect.Text = "Test Connect";
            this.Button_TestConnect.UseVisualStyleBackColor = true;
            this.Button_TestConnect.Click += new System.EventHandler(this.Button_TestConnect_Click);
            // 
            // CMW_Info
            // 
            this.CMW_Info.BackColor = System.Drawing.Color.White;
            this.CMW_Info.Location = new System.Drawing.Point(174, 242);
            this.CMW_Info.Name = "CMW_Info";
            this.CMW_Info.Size = new System.Drawing.Size(717, 35);
            this.CMW_Info.TabIndex = 3;
            this.CMW_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // List_Item
            // 
            this.List_Item.FormattingEnabled = true;
            this.List_Item.Location = new System.Drawing.Point(12, 302);
            this.List_Item.Name = "List_Item";
            this.List_Item.Size = new System.Drawing.Size(317, 340);
            this.List_Item.TabIndex = 4;
            this.List_Item.ThreeDCheckBoxes = true;
            this.List_Item.MouseMove += new System.Windows.Forms.MouseEventHandler(this.List_Item_MouseMove);
            // 
            // GPIB_Index
            // 
            this.GPIB_Index.FormattingEnabled = true;
            this.GPIB_Index.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.GPIB_Index.Location = new System.Drawing.Point(162, 58);
            this.GPIB_Index.Name = "GPIB_Index";
            this.GPIB_Index.Size = new System.Drawing.Size(36, 28);
            this.GPIB_Index.TabIndex = 4;
            this.GPIB_Index.Text = "0";
            // 
            // label_Index
            // 
            this.label_Index.AutoSize = true;
            this.label_Index.Location = new System.Drawing.Point(162, 22);
            this.label_Index.Name = "label_Index";
            this.label_Index.Size = new System.Drawing.Size(34, 20);
            this.label_Index.TabIndex = 5;
            this.label_Index.Text = "NO.";
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(218, 22);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(62, 20);
            this.label_Address.TabIndex = 6;
            this.label_Address.Text = "Address";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 750);
            this.Controls.Add(this.List_Item);
            this.Controls.Add(this.CMW_Info);
            this.Controls.Add(this.Button_TestConnect);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Address);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Setting";
            this.Text = "CMW500";
            this.Address.ResumeLayout(false);
            this.Address.PerformLayout();
            this.Port.ResumeLayout(false);
            this.Port.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Address;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox GPIB;
        private System.Windows.Forms.RadioButton ISIP;
        private System.Windows.Forms.RadioButton IsGPIB;
        private System.Windows.Forms.GroupBox Port;
        private System.Windows.Forms.TextBox RX_ATT;
        private System.Windows.Forms.TextBox TX_ATT;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Label label_RX;
        private System.Windows.Forms.Label label_TX;
        private System.Windows.Forms.Label label_Att;
        private System.Windows.Forms.ComboBox RX_Port;
        private System.Windows.Forms.ComboBox TX_Port;
        private System.Windows.Forms.Button Button_TestConnect;
        private System.Windows.Forms.Label CMW_Info;
        private System.Windows.Forms.CheckedListBox List_Item;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Index;
        private System.Windows.Forms.ComboBox GPIB_Index;
    }
}