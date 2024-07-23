using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JaAppForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        


        [STAThread]
        static void Main()
        {
            System.Threading.ThreadPool.SetMinThreads(1, 1);
            System.Threading.ThreadPool.SetMaxThreads(1, 1);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
