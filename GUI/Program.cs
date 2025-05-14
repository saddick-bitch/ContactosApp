using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 👉 Requerido para habilitar estilos visuales modernos
            Application.EnableVisualStyles();

            // 👉 Mejora el renderizado de texto (GDI+ compatible)
            Application.SetCompatibleTextRenderingDefault(false);

            // 👉 Inicia la aplicación cargando el dashboard principal
            Application.Run(new FrmMenuPrincipal());
        }
    }
}
