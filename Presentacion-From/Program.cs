using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_From
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool seguirEjecutando = true;
            while (seguirEjecutando)
            {
                frmLogin login = new frmLogin();
                if (login.ShowDialog() != DialogResult.OK)
                {
                    break;
                }

                Application.Run(new frmPrincipal());

                seguirEjecutando = frmPrincipal.CerrandoSesion;
            }
        }
    }
}
