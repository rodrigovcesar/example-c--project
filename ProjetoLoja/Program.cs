using ProjetoLoja.Model;
using System;
using System.Data.Common;
using System.Windows.Forms;

namespace ProjetoLoja
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
            Contexto banco = new Contexto();
            bool conexaoExiste = banco.Database.Exists();

            if (conexaoExiste)
            {
                Application.Run(new Form1(banco));
            }
            else
            {
                MessageBox.Show("Não foi possível detectar o banco de dados. Verifique sua conexão de internet.");
            }
            
            
             
        }

        
    }
}
