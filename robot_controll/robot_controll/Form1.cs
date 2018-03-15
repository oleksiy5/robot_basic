using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoboController;

namespace robot_controll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Robot _robot;
        private void button1_Click(object sender, EventArgs e)
        {
            if(_robot == null)
                _robot = new Robot();
            _robot.Sad(false);
            _robot.Smile(true);             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(_robot == null)
                _robot = new Robot();
            _robot.Smile(false);
            _robot.Sad(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_robot == null)
                _robot = new Robot();
            _robot.Smile(false);
            _robot.Sad(false);
        }
    }
}
