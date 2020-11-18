using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_BusinessApplicationProgramming
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
            //Application.Run(new frmAddAdmin());
            Application.Run(new frmRestaurant());
            //Application.Run(new Login());
            //Application.Run(new frmDataMenu("1"));
            //Application.Run(new frmRestaurant());
            //Application.Run(new frmBayar());
        }
    }
}
