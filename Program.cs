using System;
using System.Windows.Forms;

namespace OrderCancellerApp
{
    internal static class Program
    {
        private static bool basariliGiris = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Giris());
            if (basariliGiris == true)
            {
                Application.Run(new Uygulama());
            }
        }
        public static void BasariliGirisiAyarla(bool value)
        {
            basariliGiris = value;
        }
    }
}
