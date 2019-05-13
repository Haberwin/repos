using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO.Ports;
using System.Threading;

namespace Reboot_NBIOT
{
    public partial class Reboot_NBIoT : Form
    {
        public delegate void printDelegate(string str);
        StringBuilder ReceiverData = new StringBuilder();
        StringBuilder ReceiverError = new StringBuilder();
        public bool Device_Ready = false;
        public bool Control = true;
        public Reboot_NBIoT()
        {
            InitializeComponent();
        }

        private void BT_Start_Click(object sender, EventArgs e)
        {
            if (BT_Start.Text == "循环扫描")
            {
                BT_Start.Text = "结束循环";
                Control = true;
                PrintLog("开始循环！");
                try
                {
                    LogBox.Clear();
                    BT_Check_Port_Click(sender, e);
                    new Thread(Cycle_Test).Start();
                    //measure.Join();
                }
                catch (Exception exp)
                {
                    PrintLog(exp.Message);
                }
            }
            else
            {
                BT_Start.Text = "循环扫描";
                BT_Start.Enabled = true;
                Control = false;
                PrintLog("循环结束！");
            }




        }
        private void Cycle_Test()
        {
            while (Control)
            {
                IntPtr OffHwnd = FindWindow(null, "Power Off DUT");
                if (OffHwnd != IntPtr.Zero)
                {
                    PrintLog("Power Off DUT");
                    IntPtr OK_Hwnd = FindWindowEx(OffHwnd, IntPtr.Zero, null, "OK");
                    if (OK_Hwnd != IntPtr.Zero)
                    {
                        Device_Ready = false;
                        Send_Command("AT+CFUN=0");
                        Wait_Ready();
                        SendMessage(OK_Hwnd, 0xF5, 0, 0);
                        //WindowsForms10.BUTTON.app.0.232467a_r10_ad1
                    }
                }
                Thread.Sleep(1000);
                IntPtr OnHwnd = FindWindow(null, "Power On DUT");
                if (OnHwnd != IntPtr.Zero)
                {
                    PrintLog("Power On DUT");
                    IntPtr OK_Hwnd = FindWindowEx(OnHwnd, IntPtr.Zero, null, "OK");
                    if (OK_Hwnd != IntPtr.Zero)
                    {
                        Device_Ready = false;
                        Send_Command("AT+CFUN=1");
                        Wait_Ready();
                        SendMessage(OK_Hwnd, 0xF5, 0, 0);
                        //WindowsForms10.BUTTON.app.0.232467a_r10_ad1
                    }
                }

            }
        }
        private void Wait_Ready()
        {
            int i;
            for (i = 0; i < 60; i++)
            {
                if (Device_Ready)
                {
                    break;
                }
                Thread.Sleep(1000);
            }
            if (i == 60)
            {
                MessageBox.Show("发送AT命令超时！");
            }
        }
        private void PrintLog(String log)
        {
            if (this.LogBox.InvokeRequired)
            {
                printDelegate printInvoke = new printDelegate(PrintLog);
                this.LogBox.Invoke(printInvoke, log);
            }
            else
            {

                if (LogBox.Lines.Length > 3000)
                {
                    int index = LogBox.Text.IndexOf("\n");
                    int moreLines = this.LogBox.Lines.Length - 500;
                    string[] lines = this.LogBox.Lines;
                    Array.Copy(lines, moreLines, lines, 0, 500);
                    Array.Resize(ref lines, 500);
                    this.LogBox.Lines = lines;
                }
                log = Regex.Replace(String.Format("{0}|{1}\n", DateTime.Now.ToString("hh:mm:ss"), log), @"[\r\n]+", "\r\n");
                //this.LogBox.SelectionColor = color;
                this.LogBox.AppendText(log);
                byte[] LogByte = this.SerialPort_IoT.Encoding.GetBytes(log);
     

                LogBox.ScrollToCaret();
            }
        }


        private void Send_Command(string command)
        {
            if (this.SerialPort_IoT.PortName == "COM1")
            {
                PrintLog("No Port select!");
                return;
            }
            else if (!this.SerialPort_IoT.IsOpen)
            {
                SerialPort_IoT.Open();
            }
            this.SerialPort_IoT.Write(command + "\r\n");
            PrintLog("<<<" + command);
        }
        private void Scan_SerialPort()
        {
            string[] ports = SerialPort.GetPortNames();//检查是否含有串口 
            ListBox_Com.Items.Clear();
            if (ports == null)
            {
                return;
            }

            foreach (string port in ports)   //添加串口
            {

                ListBox_Com.Items.Add(port);
                ListBox_Com.SelectedIndex = 0;
            }
        }











        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("User32.dll", EntryPoint = "FindWindowEx")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private void Reboot_NBIoT_Load(object sender, EventArgs e)
        {
            Scan_SerialPort();
        }

        private void ListBox_Com_MouseEnter(object sender, EventArgs e)
        {
            Scan_SerialPort();
        }

        private void BT_Check_Port_Click(object sender, EventArgs e)
        {
            if (ListBox_Com.Text != "")
            {
                if(SerialPort_IoT.IsOpen)
                {
                    PrintLog("串口" + ListBox_Com.Text + "已打开!");
                    return;
                }
                this.SerialPort_IoT.PortName = this.ListBox_Com.Text;
                this.SerialPort_IoT.BaudRate = 115200;
                this.SerialPort_IoT.DataBits = 8;
                this.SerialPort_IoT.Parity = Parity.None;
                this.SerialPort_IoT.StopBits = StopBits.One;
                this.SerialPort_IoT.Open();
                if (SerialPort_IoT.IsOpen)
                {
                    PrintLog("打开串口" + ListBox_Com.Text + "成功!");
                }
                else
                {
                    PrintLog("打开串口" + ListBox_Com.Text + "失败!");
                }

            }
            else
            {
                MessageBox.Show("找不到可连接的COM端口！");
            }
        }

        private void SerialPort_IoT_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(50);
            int n = this.SerialPort_IoT.BytesToRead;
            byte[] buf = new byte[n];
            this.SerialPort_IoT.Read(buf, 0, n);
            ReceiverData.Append(this.SerialPort_IoT.Encoding.GetString(buf));
            String Feedback = ReceiverData.ToString();
            if (Feedback.EndsWith("\n"))
            {
                PrintLog(">>>" + Feedback);
                ReceiverData.Remove(0, ReceiverData.Length);
                if ( Feedback.Contains("\r\nOK\r\n"))
                {
                    Device_Ready = true;
                }
            }
        }

        private void Reboot_NBIoT_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control = false;
            if (SerialPort_IoT.IsOpen)
            {
                SerialPort_IoT.Close();
            }
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            if (SerialPort_IoT.IsOpen)
            {
                SerialPort_IoT.Close();
            }
        }
    }

}

