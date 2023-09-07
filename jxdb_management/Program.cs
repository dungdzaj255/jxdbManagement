using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Text;

namespace jxdb_management
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            if (IsRunning() == false)
            {
                Application.EnableVisualStyles();
                ApplicationConfiguration.Initialize();
                Login login = new Login();
                MainForm mainForm = new MainForm();
                Application.Run(mainForm);
            }
            else
            {
                MessageBox.Show("The app is already running!");
            }
        }

        private static bool IsRunning()
        {
            Process curr = Process.GetCurrentProcess();
            Process[] procs = Process.GetProcessesByName(curr.ProcessName);

            return procs.Any(p => (p.Id != curr.Id) && (p.MainModule.FileName == curr.MainModule.FileName));
        }
    }
}