using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lego
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


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
