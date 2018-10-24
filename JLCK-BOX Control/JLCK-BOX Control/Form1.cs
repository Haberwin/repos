using Modbus.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JLCK_BOX_Control
{
    public partial class JLCK_BOX : Form
    {
        public JLCK_BOX()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 创建 ModBus RTU 连接
        /// </summary>
        /// <param name="portName">端口号</param>
        /// <param name="baudRate">波特率</param>
        /// <param name="parity">奇偶校验位</param>
        /// <param name="dataBits">数据位</param>
        /// <param name="stopBits">停止位</param>
        /// <returns></returns>
        public IModbusSerialMaster CreateModBusRtuConnection(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            return CreateModBusRtuConnection(new SerialPort(portName, baudRate, parity, dataBits, stopBits));
        }

        public IModbusSerialMaster CreateModBusRtuConnection(SerialPort serialPort)
        {
            IModbusSerialMaster master = null;
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.Open();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            try
            {
                master = ModbusSerialMaster.CreateRtu(serialPort);
                ///同时也可以配置master的一些参数
                master.Transport.ReadTimeout = 100;//读取数据超时100ms
                master.Transport.WriteTimeout = 100;//写入数据超时100ms
                master.Transport.Retries = 3;//重试次数
                master.Transport.WaitToRetryMilliseconds = 10;//重试间隔

            }
            catch (Exception e)
            {
                throw e;
            }
            return master;
        }
    }
}

