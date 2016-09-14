using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTextSharpDemo
{
    static class Program
    {
        /// <sumario>
        /// The main entry point for the application.
        /// </summary>
		/// Esto es una prueba de modificación
		static int numero;
        [STAThread]
        static void Main()
        {
			numero = 10;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
