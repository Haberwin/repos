using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace NBIoT
{
    public partial class Sheet2
    {
        private void Sheet2_Startup(object sender, System.EventArgs e)
        {
           
        }

        private void Sheet2_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO 设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            this.Startup += new System.EventHandler(this.Sheet2_Startup);
            this.Shutdown += new System.EventHandler(this.Sheet2_Shutdown);

        }

        #endregion

        private void Button_Open_Click(object sender, EventArgs e)
        {
            Form form = new Setting();
            form.Show();
            form.TopMost = true;
        }
    }
    internal sealed class Visa32
    {
        /*
        public bool GetVi()
        {
            //CalibrationCurrent.Properties.Resources.cmd2
            //ErrorStatus = -1;
            short t1 = 1, t2 = 0;
            GPIB_Address = GPIB.Text;
            Visa32.viGetDefaultRM(out int defrm);
            Thread.Sleep(200);
            if (ErrorStatus != 0)
            {
                Visa32.viParseRsrcEx(defrm, "GPIB0::" + GPIB_Address + "::0::INSTR", ref t1, ref t2, instr, null, null);
                ErrorStatus = Visa32.viOpen(defrm, "GPIB0::" + GPIB_Address + "::0::INSTR", 1, 3000, out Vi);
                if (ErrorStatus != 0)
                {
                    Output(ErrorStatus.ToString());
                    Output("GPIB address unavailable!");

                    Result.Text = "FAIL";
                    Result.BackColor = Color.OrangeRed;
                    return false;
                }
            }
            */
        // --------------------------------------------------------------------------------
        //  Adapted from visa32.bas which was distributed by VXIplug&play Systems Alliance
        //  Distributed By Agilent Technologies, Inc.
        // --------------------------------------------------------------------------------
        // -------------------------------------------------------------------------
        public const int VI_SPEC_VERSION = 4194304;
        #pragma warning disable IDE1006 // 命名样式
        #region - Resource Template Functions and Operations ----------------------------
        [DllImportAttribute("Visa32.dll", EntryPoint = "#141", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int viOpenDefaultRM(out int sesn);
        [DllImportAttribute("Visa32.dll", EntryPoint = "#128", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int viGetDefaultRM(out int sesn);
        [DllImportAttribute("Visa32.dll", EntryPoint = "#131", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int viOpen(int sesn, string viDesc, int mode, int timeout, out int vi);
        [DllImportAttribute("Visa32.dll", EntryPoint = "#132", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int viClose(int vi);
        [DllImportAttribute("Visa32.DLL", EntryPoint = "#146", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern int viParseRsrcEx(int sesn, string desc, ref short intfType, ref short intfNum, StringBuilder rsrcClass, StringBuilder expandedUnaliasedName, StringBuilder aliasIfExists);
        [DllImportAttribute("Visa32.dll", EntryPoint = "#269", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int viPrintf(int vi, string writeFmt);
        [DllImportAttribute("Visa32.dll", EntryPoint = "#271", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public static extern int viScanf(int vi, string readFmt, StringBuilder arg);
        #endregion
        #pragma warning restore IDE1006 // 命名样式
    }


}
