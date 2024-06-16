using Lab_24_Dykyi;
using System;
using System.Windows.Forms;

namespace MultiThreadingEncryption
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}