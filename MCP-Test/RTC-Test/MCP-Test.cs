using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using NationalInstruments.VisaNS;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace MCP_Test
{
    public partial class MCP_Form : Form
    {
        
        
        private MessageBasedSession mbSession;
        private delegate void SetVoltage(string str);
        private delegate void ClearChart();
        private List<float> listOnTime= new List<float>();
        private decimal limitVoltage,limitCurrent;
        private int stepTime;
        private int testCycle,offTime;
        private List<int> xTime = new List<int>();
        private List<double> yCurrent = new List<double>();
        private List<float> yVoltage = new List<float>();
        private bool connectStatus=false;
        private string Device_Address;
        private Thread measure;
        public MCP_Form()
        {
            InitializeComponent();
            chart1.Series[0].Points.DataBindXY(xTime, yVoltage);
            chart1.Series[1].Points.DataBindXY(xTime, yCurrent);
        }

        

        private void Button_scan_Click(object sender, EventArgs e)
        {
            Scan_Devices();
        }

        /// <summary>
        /// 扫描已连接的设备资源
        /// 
        /// </summary>
        private void Scan_Devices()
        {
            PowerSupply.Items.Clear();
            connectStatus = false;
            try
            {
                string[] resources = ResourceManager.GetLocalManager().FindResources("GPIB?*INSTR");

                if (resources.Length == 0)
                {
                    Device_Info.Text = "No Device";
                    MessageBox.Show("No available device found,please check again!");
                }
                foreach (string s in resources)
                {
                    PowerSupply.Items.Add(s);

                    //MessageBox.Show("Find resource:" + s);
                    PowerSupply.SelectedIndex = 0;
                    Device_Address = PowerSupply.Text;

                }
                
                
            }
            catch (System.DllNotFoundException)
            {
                MessageBox.Show("The NI-VISA driver library cannot be found.");

            }
            catch (System.EntryPointNotFoundException)
            {
                MessageBox.Show("A required operation in the NI-VISA driver library cannot be found.");
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("GPIB Device Not Found!");
            }
               
            catch (Exception visaExp)
            {
                MessageBox.Show(visaExp.Message);
            } 
        }
      
        /// <summary>
        /// 初始化设备
        /// </summary>
        /// <param name="Device_Address"></param>设备的GPIB地址
        private void Measure_Voltage()
        {  
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                String responseString="0.0", textToWrite;

                textToWrite = ReplaceCommonEscapeSequences("MEAS:VOLT:DC? 10V,0.0001V\\n");
                responseString = mbSession.Query(textToWrite);  
            }
            catch (ThreadAbortException)
            {
                //Print_Log("终止线程!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        /*
        private void Send_Result(string volt)
        {
            string voltage = String.Format("{0:F3}", Convert.ToSingle(volt));
            if (this.Current.InvokeRequired)
            {
                SetVoltage setvotage = new SetVoltage(Send_Result);
                this.Current.Invoke(setvotage, voltage);
            }
            else
            {
                this.Current.Text = voltage;
            }
        }
        */
        /// <summary>
        /// 根据当前选择的地址返回设备基本信息
        /// </summary>
        private void Query_IDN(String Device_address)
        {

            Cursor.Current = Cursors.WaitCursor;
            connectStatus = false;
            try
            {
                mbSession = (MessageBasedSession)ResourceManager.GetLocalManager().Open(Device_address);
                Device_Address = PowerSupply.Text;
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Resource selected must be a message-based session");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            try
            {
                mbSession.Write(ReplaceCommonEscapeSequences("*RST\\n"));
                mbSession.Write(ReplaceCommonEscapeSequences("*CLS\\n"));
                string textToWrite = ReplaceCommonEscapeSequences("*IDN?\\n");
                string responseString = mbSession.Query(textToWrite);
                Device_Info.Text = InsertCommonEscapeSequences(responseString);
                //Print_Log("Find device:" + responseString);
                connectStatus = true;
                return;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        /// <summary>
        /// 字符转换函数
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private string ReplaceCommonEscapeSequences(string s)
        {
            return s.Replace("\\n", "\n").Replace("\\r", "\r");
        }

        private string InsertCommonEscapeSequences(string s)
        {
            return s.Replace("\n", "\\n").Replace("\r", "\\r");
        }

        private void List_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query_IDN(PowerSupply.Text);
        }

        public void Set_Round(string log)
        {
            
            if (this.RoundNum.InvokeRequired)
            {
                SetVoltage printlog = new SetVoltage(Set_Round);
                this.RoundNum.Invoke(printlog, log);
            }
            else
            {
                RoundNum.Text = String.Format("Round {0}", testCycle);
            }
            
        }
        private void Clear_Series()
        {
            if (this.chart1.InvokeRequired)
            {
                ClearChart clear_chart1 = new ClearChart(Clear_Series);
                this.chart1.Invoke(clear_chart1);
            }
            else
            {
                xTime.Clear();
                yCurrent.Clear();
                yVoltage.Clear();
                chart1.Series[0].Points.DataBindXY(xTime, yVoltage);
                chart1.Series[1].Points.DataBindXY(xTime, yCurrent);
                stepTime = 0;
            }
        }
       

        private void MCP_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (measure != null && measure.IsAlive)
            {
                try
                {
                    measure.Abort();
                }
                catch (ThreadAbortException)
                {
                    //Print_Log("终止线程");
                }
                finally
                {
                    measure.Join();
                }
            }
           
                

        }
        private void StartCycle()
        {
            try
            {
                for (testCycle = 1; testCycle < testCycle + 1; testCycle++)
                {
                    Clear_Series();
                    Set_Round(String.Format("Round {0}", testCycle));
                    foreach (int on_time in listOnTime)
                    {
                        lock (mbSession)
                        {
                            mbSession.Write(ReplaceCommonEscapeSequences("OUTP 1\\n"));
                        }
                            Thread.Sleep(on_time * 1000);
                        lock (mbSession) { 
                            mbSession.Write(ReplaceCommonEscapeSequences("OUTP 0\\n"));
                            
                        }
                        Thread.Sleep(offTime * 1000);
                    }
                }
            }
            catch (ThreadAbortException)
            {
                //Print_Log("终止线程!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        /*
        private void TextBox_Barcode_TextChanged(object sender, EventArgs e)
        {
            
            if(TextBox_Barcode.Text.Length==10)
            {
                SN_Code = TextBox_Barcode.Text;            
                if (Device_Address == null)
                {
                    MessageBox.Show("找不到可连接的 Agilent 34401A！");
                    TextBox_Barcode.Clear();
                    TextBox_Barcode.Focus();
                    return;
                }              
                TextBox_Barcode.Clear();
                TextBox_Barcode.Focus();
                Current.Text = "0.00";
                Result.BackColor = Color.Yellow;
                Result.Text = "测试中,请等待......";
                Result.Update();
                Log.Clear();
                try
                {
                    if (measure != null && measure.IsAlive)
                    {
                        try
                        {
                            measure.Abort();
                        }
                        catch (ThreadAbortException)
                        {
                            Print_Log("终止线程");
                        }
                        finally
                        {
                            measure.Join();
                        }
                    }

                    measure = new Thread(Measure_Voltage);
                    measure.Start();
                    //measure.Join();
                }
                catch (Exception exp)
                {
                    Log.AppendText(exp.Message);
                }
                
                
            }
            if (TextBox_Barcode.Text.Length > 10)
            {
                Print_Log("输入字符超出预定长度，已重置！");
                TextBox_Barcode.Clear();

            }
          

    }
      */
        private void MCP_Form_Shown(object sender, EventArgs e)
        {
            Scan_Devices();
            limitCurrent = Current.Value;
            limitVoltage = Voltage.Value;
            testCycle = decimal.ToInt16(Cycles.Value);
            offTime= decimal.ToInt16(OffTime.Value);
            foreach (string i in TimeList.Text.Split(','))
            {
                listOnTime.Add(float.Parse(i));

            }
        }

        private void Voltage_ValueChanged(object sender, EventArgs e)
        {
            limitVoltage = Voltage.Value;
        }

        private void Current_ValueChanged(object sender, EventArgs e)
        {
            limitCurrent = Current.Value;
        }

        private void OffTime_ValueChanged(object sender, EventArgs e)
        {
            offTime = decimal.ToInt16(OffTime.Value);
        }

        private void TimeList_TextChanged(object sender, EventArgs e)
        {
            List<float> tempList = new List<float>();
            try
            {
                foreach (string i in TimeList.Text.Split(','))
                {
                    if( i != "")
                    {
                        tempList.Add(float.Parse(i));
                    }   

                }
            }
            catch
            {
                MessageBox.Show("输入的格式有误，请输入正确的数字并用英文','分割！");
                return;
            }
            listOnTime = tempList;
        }

        private void Init_BT_Click(object sender, EventArgs e)
        {
            if (!connectStatus)
            {
                MessageBox.Show("Please select Power supply first!");
                return;
            }
            mbSession.Write(ReplaceCommonEscapeSequences("*RST\\n"));
            mbSession.Write(ReplaceCommonEscapeSequences("*CLS\\n"));
            mbSession.Write(ReplaceCommonEscapeSequences(String.Format("VOLT {0}\\n",limitVoltage)));
            mbSession.Write(ReplaceCommonEscapeSequences(String.Format("CURR {0}\\n", limitCurrent)));
            //mbSession.Write(ReplaceCommonEscapeSequences(String.Format("OUTP 1\\n", limitCurrent)));


        }

        private void Control_BT_Click(object sender, EventArgs e)
        {
            if (Control_BT.Text == "Start")
            {
                
                Init_BT_Click(sender, e);
                if (!connectStatus)
                {
                    //MessageBox.Show("Please select Power supply first!");
                    return;
                }
                //mbSession.Write(ReplaceCommonEscapeSequences("OUTP 1\\n"));
                Control_BT.Text = "Stop";
                this.Control_BT.Image = global::MCP_Test.Properties.Resources.Stop;
                Control_BT.ForeColor = System.Drawing.Color.Red;
                measure = new Thread(StartCycle);
                measure.Start();
                timer_Test.Start();

            }
            else
            {
                timer_Test.Stop();
                Control_BT.Text = "Start";
                this.Control_BT.Image = global::MCP_Test.Properties.Resources.Start;
                Control_BT.ForeColor = System.Drawing.Color.GreenYellow;
                if (measure != null && measure.IsAlive)
                {
                    try
                    {
                        measure.Abort();
                    }
                    catch (ThreadAbortException)
                    {
                        //Print_Log("终止线程");
                    }
                    finally
                    {
                        measure.Join();
                    }
                }
            }
        


        
        }

        private void Timer_Test_Tick(object sender, EventArgs e)
    {

            float VolNow=0, CurNow=0;
            try {
                lock (mbSession)
                {
                    VolNow = (float)Math.Round(float.Parse(mbSession.Query(ReplaceCommonEscapeSequences("MEAS:VOLT?\\n"))), 2);
                    CurNow = (float)Math.Round(float.Parse(mbSession.Query(ReplaceCommonEscapeSequences("MEAS:CURR?\\n")))*1000, 1); 
                    
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("无法获取到电流电压的返回值！");
                return;
            }
            
            //stepTime,new Random().Next(0, 4));
            yVoltage.Add(VolNow);
            if (show_Vol.Checked)
            {
                chart1.Series[0].Points.AddXY(stepTime, VolNow);
            }

            //double Ycurrent = new Random(System.DateTime.Now.Millisecond).Next(1, 3000) / 10000.0;
            //chart1.Series[1].Points.AddXY(stepTime,Ycurrent);
            yCurrent.Add(CurNow);

            if (show_Cur.Checked)
            {
                chart1.Series[1].Points.AddXY(stepTime, CurNow);
            }
            labelCurrrent.Text = String.Format("{0} mA", CurNow.ToString());
            //
            // chart1.Series[0].Points.Add();
            xTime.Add(stepTime);
            stepTime += 1;
            
        }

        private void Show_Vol_CheckedChanged(object sender, EventArgs e)
        {
            if (show_Vol.Checked)
            {
                chart1.Series[0].Points.DataBindXY(xTime, yVoltage);
            }
            else
            {
                chart1.Series[0].Points.Clear();
            }
        }

        private void Show_Cur_CheckedChanged(object sender, EventArgs e)
        {
            if (show_Cur.Checked)
            {
                chart1.Series[1].Points.DataBindXY(xTime, yCurrent);
            }
            else
            {
                chart1.Series[1].Points.Clear();
            }

        }

        private void RoundNum_DoubleClick(object sender, EventArgs e)
        {
            testCycle = 1;
            RoundNum.Text = String.Format("Round {0}",testCycle);
        }

        private void Cycles_ValueChanged(object sender, EventArgs e)
        {
            testCycle = decimal.ToInt16(Cycles.Value);
        }
        /*
        private void Current_TextChanged(object sender, EventArgs e)
        {
            string Jugged = "Fail";
            if (Current.Text.Equals("0.00"))
            {
                return;
            }
            try
            {
                if (float.Parse(Current.Text) <= 3.4 && float.Parse(Current.Text) >= 2.5)
                {
                    Jugged = "Pass";
                }
                else
                {
                    Jugged = "Fail";
                    Current.BackColor = Color.OrangeRed;
                    return;
                }
            }
            catch (Exception)
            {
                Current.BackColor = Color.OrangeRed;
                return;
            }
            
            
            //byte[] SN = Encoding.ASCII.GetBytes(String.Format("{0}\0",SN_Code));
            byte[] Current_Value = Encoding.ASCII.GetBytes(String.Format("{0}\0", Current.Text));
            byte[] Juged_Value= Encoding.ASCII.GetBytes(String.Format("{0}\0", Jugged));
            try
            {
                //string msg = String.Format("Barcode ={0},Voltage ={1},Result ={2}", SN_Code, Current.Text, Jugged);
                string filename = String.Format("log/MCP-Log-{0:yyyy-MM-dd}.txt", System.DateTime.Now);
                FileStream fs;
                if (File.Exists(filename))
                {
                     fs= new FileStream(filename, FileMode.Append, FileAccess.Write);
                    
                }
                else
                {
                    fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                }
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                //sw.WriteLine(msg);

                sw.Close(); //关闭文件
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
 */
        

    }
    

}
