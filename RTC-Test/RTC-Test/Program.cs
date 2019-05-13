using System;
using System.Windows.Forms;

namespace RTC_Test
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try {
                Application.Run(new RTC_Form());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
           
        }
    }
}
