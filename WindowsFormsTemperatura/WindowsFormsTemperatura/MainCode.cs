using System;
using System.Windows.Forms;

namespace WindowsFormsTemperatura
{
    internal static class MainCode
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new App());
        }
    }
}
