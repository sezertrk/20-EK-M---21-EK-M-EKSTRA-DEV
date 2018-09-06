using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _20_EKİM___21_EKİM_EKSTRA_ÖDEV
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
}
