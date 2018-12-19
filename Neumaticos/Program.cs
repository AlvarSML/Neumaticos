using System;
using System.Windows.Forms;

namespace Neumaticos {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            //OJO: SOLO EN CASO DE DESPLIEGUE CAMBIAR LA RUTA DEL DIRECTORIO DE DATOS
            ///string rutaAppData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string rutaAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            AppDomain.CurrentDomain.SetData("DataDirectory", rutaAppData);
                                             
            //SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuInicial());
        }
    }
}
