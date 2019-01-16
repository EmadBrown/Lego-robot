using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using EV3MessengerLib;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System.Diagnostics;

namespace lego
{
    public partial class Form1 : Form
    {
        Brick bricka;
        EV3Messenger messenger;
        EV3Message message;
        Stopwatch stopwatch;
        Stopwatch stopwatchTimer = new Stopwatch();
        Stopwatch stopwatchTimer2 = new Stopwatch();
        Robot_States robot_States;

        public Form1()
        {
            InitializeComponent();
            messenger = new EV3Messenger();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (messenger.Connect("COM7"))
            {
                MessageBox.Show("AUTOMATIC MODE ON");
            }
            else
            {
                MessageBox.Show("Can't Connect");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            robot_States = Robot_States.starting;
            while (robot_States != Robot_States.paused)
            {
                message = messenger.ReadMessage();
                if (message != null)
                {
                    //
                }
            }

          // Start
          //
           //
        }
    }

    public enum Robot_States
    {
        starting = 0,
        lineFollowing,
        grabbingObject,
        rotating,
        advancing,
        deliveringObject,
        retracting,
        paused,
        missionCompleted,
    }
}
