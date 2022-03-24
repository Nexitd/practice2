using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Airoport
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Sandbox.screen frm = new Sandbox.screen();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(11.5);
            frm.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }

            frm.Close();
            frm.Dispose();

            Application.Run(new Sandbox.Form1());
        }
    }
}
