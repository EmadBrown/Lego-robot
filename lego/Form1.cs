using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
