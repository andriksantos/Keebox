﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloatbox
{
    static class Program
    {
        internal static string GetCurrentVersionTostring() => new Version(Application.ProductVersion).ToString(3);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
      {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Environment.OSVersion.Version.Build < 9200)

                MessageBox.Show("You are running Bloatbox on a system older than Windows 10. Bloatbox is limited to Windows 10 ONLY.", "Bloatbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                Application.Run(new MainWindow());

        }
    }
}
