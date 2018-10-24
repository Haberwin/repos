using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NBIoT
{
    public partial class Setting : Form
    {
        Cmw500 cmw;
        int Vi;
        string address;
        public Setting()
        {
            InitializeComponent();
            foreach (Worksheet sheets in Globals.ThisWorkbook.Sheets){
                if(!(sheets.Name == "Version"||sheets.Name == "Summary"))
                {
                    List_Item.Items.Add(sheets.Name);
                }
            }
        }

        private void Button_TestConnect_Click(object sender, EventArgs e)
        {
            string CmwAddress = GetAddress();
            if (CmwAddress == "Error")
            {
                return;
            }
            cmw = new Cmw500
            {
                Address = CmwAddress
            };
            Vi = cmw.GetVi();
            if (Vi==0)
            {
                CMW_Info.Text = "Can't Found Cmw500 device,Please check the connection again";
                CMW_Info.BackColor = Color.Red;
                return;
            }
            CMW_Info.Text = cmw.GetCmwInfo();
            CMW_Info.BackColor = Color.Green;
            //cmw.Address=

        }
        private string GetAddress()
        {
            if (IsGPIB.Checked)
            {
                if(GPIB.Text=="" || GPIB_Index.Text == "")
                {
                    Console.WriteLine("GPIB Address Error!");
                    return ("Error");
                }
                Console.WriteLine(String.Format("Connect to GPIB{0}::{1}::0::INSTR",GPIB_Index.Text,GPIB.Text));
                return (String.Format("GPIB{0}::{1}::0::INSTR",GPIB_Index.Text,GPIB.Text));
            }
            else
            {
                if(IP.Text=="")
                {
                    Console.WriteLine("IP Address Error!");
                    return ("Error");

                }
                Console.WriteLine(String.Format("Connect to TCPIP0:{0}::inst0::INSTR", IP.Text));
                return (String.Format("TCPIP0:{0}::INSTR",IP.Text));
            }
        }

        private void List_Item_MouseMove(object sender, MouseEventArgs e)
        {
            List_Item.SelectedIndex= List_Item.IndexFromPoint(e.X, e.Y);
        }
    }
    public class Cmw500
    {
        public StringBuilder Feedback = new StringBuilder("", 3000);
        public int Vi,ErrorStatus=-1; 
        public string Tx_Port, Rx_port;
        public string Address;
        public int GetVi()
        {
            Visa32.viGetDefaultRM(out int defrm);
            ErrorStatus = Visa32.viOpen(defrm,  Address , 1, 3000, out Vi);
            if (ErrorStatus != 0)
            {
                return 0;
            }
            return Vi;
        }
        public string GetCmwInfo()
        {
            Visa32.viPrintf(Vi, "*IDN?" + System.Environment.NewLine);
            return GetFeedBack();

        }
        private string GetFeedBack()
        {
            Feedback.Remove(0, Feedback.Length);           
            Thread.Sleep(500);
            Visa32.viScanf(Vi, "%t", Feedback);
            return Feedback.ToString();

        }
    }
}
