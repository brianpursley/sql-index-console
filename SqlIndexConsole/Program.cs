using SqlIndexConsole.Properties;
using System;
using System.Windows.Forms;

namespace SqlIndexConsole
{
    public static class Program
    {
        internal static readonly Settings Settings = Settings.Default;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
