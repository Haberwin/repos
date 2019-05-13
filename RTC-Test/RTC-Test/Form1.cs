using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using NationalInstruments.VisaNS;
using System.IO;
using System.Text;

namespace RTC_Test
{
    public partial class RTC_Form : Form
    {
        int nStatus=0;
        public string SN_Code = "";
        public IntPtr snp, cup, rep;
        //public string Current_Value, Result_Value;
        private MessageBasedSession mbSession;
        public delegate void SetVoltage(string str);
        public string Device_Address;
        public Thread measure;
        int Statu_Init, Statu_Connect;
        public RTC_Form()
        {
            InitializeComponent();
        }

        

        private void Button_scan_Click(object sender, EventArgs e)
        {
            Scan_Devices();
            TextBox_Barcode.Focus();
        }

        /// <summary>
        /// 扫描已连接的设备资源
        /// 
        /// </summary>
        private void Scan_Devices()
        {
            list_devices.Items.Clear();
            try
            {
                string[] resources = ResourceManager.GetLocalManager().FindResources("GPIB?*INSTR");

                if (resources.Length == 0)
                {
                    Device_Info.Text = "No Device";
                    Print_Log("No available device found,please check again!");
                }
                foreach (string s in resources)
                {
                    list_devices.Items.Add(s);
                    
                    Print_Log("Find resource:" + s);
                    list_devices.SelectedIndex = 0;
                    Device_Address = list_devices.Text;

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
                //Send_Result("0.0");
                int Valid_Num = 0;
                float Sum_Voltage = 0;
                String responseString="0.0", textToWrite;
                for (int i = 0; i < 3; i++)
                {
                    Print_Log(String.Format("将在{0}秒后开始测量...", 3-i));
                    Thread.Sleep(1000);
                }
                Print_Log("开始测量...");
                for (int i=0; i<10;i++)
                {
                    textToWrite = ReplaceCommonEscapeSequences("MEAS:VOLT:DC? 10V,0.0001V\\n");
                    responseString = mbSession.Query(textToWrite);
                    if (float.Parse(responseString) < 2)
                    {
                        Print_Log(String.Format("第{0}次测量：无效电压{1:F4}" ,i,responseString));
                    }
                    else
                    {
                        Valid_Num++;
                        Sum_Voltage += float.Parse(responseString);
                        Print_Log(String.Format("第{0}次测量：{1:F4}", i, responseString));
                    }

                    Thread.Sleep(500);
                }
                if (Valid_Num != 0)
                {
                    Print_Log(String.Format("{0}次有效测量平均值：{1:F4}", Valid_Num, Sum_Voltage/Valid_Num));
                    Send_Result((Sum_Voltage / Valid_Num).ToString());
                }
                else
                {
                    Send_Result(responseString);
                }
                //mbSession.Write(ReplaceCommonEscapeSequences("MEAS:VOLT:DC? \\n"));
                
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
        /// <summary>
        /// 根据当前选择的地址返回设备基本信息
        /// </summary>
        private void Query_IDN(String Device_address)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                mbSession = (MessageBasedSession)ResourceManager.GetLocalManager().Open(Device_address);
                Device_Address = list_devices.Text;
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
                Print_Log("Find device:" + responseString);
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
            Query_IDN(list_devices.Text);
        }

        public void Print_Log(string log)
        {
            if (this.Log.InvokeRequired)
            {
                SetVoltage printlog = new SetVoltage(Print_Log);
                this.Current.Invoke(printlog, log);
            }
            else
            {
                this.Log.AppendText(String.Format("{0}|{1}\n", DateTime.Now.ToString("hh:mm:ss"), log));
            }

        }
       

        private void RTC_Form_FormClosing(object sender, FormClosingEventArgs e)
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
            try
            {
                CloseConnectionSuivi();
            }
            catch(Exception exp)
            {
                MessageBox.Show("关闭服务器失败");
            }
                

        }

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
        private void RTC_Form_Shown(object sender, EventArgs e)
        {
            Scan_Devices();
            Statu_Init = InitIndexSuivi();

            if (Statu_Init != 0)
            {
                MessageBox.Show("Dll 初始化失败!");
            }
            else
            {
                Print_Log("Dll 初始化成功!");
            }
            TextBox_Barcode.Focus();
        }

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
                    Result.Text = "Fail";
                    Result.BackColor = Color.OrangeRed;
                    return;
                }
            }
            catch (Exception)
            {
                Current.BackColor = Color.OrangeRed;
                Result.Text = "Fail";
                Result.BackColor = Color.OrangeRed;
                return;
            }
            TextBox_Barcode.Clear();
            TextBox_Barcode.Focus();
            if (IsConnection() == 0)
            {
                Print_Log("已连接数据库！");
            }
            else
            {
                Print_Log("重新连接接数据库");
                Statu_Init = InitIndexSuivi();
                if (Statu_Init != 0)
                {
                    MessageBox.Show("Dll 初始化失败!");
                    Current.BackColor = Color.OrangeRed;
                    Result.Text = "Fail";
                    Result.BackColor = Color.OrangeRed;
                    return;
                }
                Print_Log("Dll 初始化成功!");

                Statu_Connect = InitConnectionSuivi();
                if (Statu_Connect != 0)
                {
                    Current.BackColor = Color.OrangeRed;
                    Result.Text = "Fail";
                    Result.BackColor = Color.OrangeRed;
                    MessageBox.Show("Suivi 连接数据库 初始化失败!");
                    return;
                }
                Print_Log("Suivi 连接数据库 初始化成功!");
            }
           
            
            byte[] SN = Encoding.ASCII.GetBytes(String.Format("{0}\0",SN_Code));
            byte[] Current_Value = Encoding.ASCII.GetBytes(String.Format("{0}\0", Current.Text));
            byte[] Juged_Value= Encoding.ASCII.GetBytes(String.Format("{0}\0", Jugged));
            try
            {
                string msg = String.Format("Barcode ={0},Voltage ={1},Result ={2}", SN_Code, Current.Text, Jugged);
                string filename = String.Format("log/RTC-Log-{0:yyyy-MM-dd}.txt", System.DateTime.Now);
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
                sw.WriteLine(msg);

                sw.Close(); //关闭文件
                Print_Log(String.Format("本地保存数据成功:{0}", msg));
                if (UpdateStatut(SN, Current_Value, Juged_Value) == 1)
                {
                    Print_Log(String.Format("成功更新数据:{0}", msg));
                    Current.BackColor = Color.LightGreen;
                    Result.Text = "Pass";
                    Result.BackColor = Color.LightGreen;
                    CloseConnectionSuivi();
                    return;
                }
                else
                {
                    Print_Log("上传数据库失败!");
                }
                CloseConnectionSuivi();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                CloseConnectionSuivi();
            }
            Current.BackColor = Color.OrangeRed;
            Result.Text = "Fail";
            Result.BackColor = Color.OrangeRed;

        }
 
        

        [DllImport("TingSuiviApplication.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public static extern int InitIndexSuivi();
        [DllImport("TingSuiviApplication.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int InitConnectionSuivi();
        [DllImport("TingSuiviApplication.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int IsConnection();
        [DllImport("TingSuiviApplication.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void CloseConnectionSuivi();
        [DllImport("TingSuiviApplication.dll",CallingConvention = CallingConvention.Cdecl)]
        public static extern int UpdateStatut(byte[] numSN,byte[] Voltage,byte[] Statuts);
    }
    

}
