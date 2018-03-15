using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace RoboController
{
    //public
    //private
    //protected       
    //internal
    //protected internal

    public class Robot
    {
        #region 

        SerialPort _port;

        int _activeTime = 3000;

        public Robot()
        {
            _port = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            _port.Open();
        }

        public Robot(int activeTime)
        {
            _port = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            _port.Open();
            _activeTime = activeTime;
        }

        ~Robot()
        {
            if (_port != null && _port.IsOpen)
                _port.Close();
        }

        private void SendData(string data)
        {
            if (_port != null && _port.IsOpen)
                _port.Write(data);
            else
                throw new Exception("Port is closed");
        }

        public void Smile(bool isOn)
        {
            if (isOn)
            {
                SendData("HAPPY_ON");
                Thread.Sleep(_activeTime);
                SendData("HAPPY_OFF");
            }
            else
                SendData("HAPPY_OFF");
        }

        public void Sad(bool isOn)
        {
            if (isOn)
            {
                SendData("SAD_ON");
                Thread.Sleep(_activeTime);
                SendData("SAD_OFF");
            }
            else
                SendData("SAD_OFF");
        }

        public void Sleep()
        {
            SendData("HAPPY_OFF");
            SendData("SAD_OFF");
        }    

        #endregion
    }
}
