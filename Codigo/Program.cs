using Urilyzer100.Utilities;
using System;
using System.Windows.Forms;

namespace Urilyzer100
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
            InterfaceConfig.InitializeConfig();
            Application.Run(new Dashboard());
        }
    }
}