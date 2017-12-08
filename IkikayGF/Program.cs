using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Using perso
using IkikayGF.Forms;

namespace IkikayGF
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Dashboard FormMain = new Dashboard();
            FormMain.Show();

            Application.Run();
        }
    }
}
