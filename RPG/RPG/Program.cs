using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPG.Projets.GestionUtilisateur;
using RPG.Projets.Jeu;
using RPG.Projets.GestionUtilisateur.GUI;

namespace RPG
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
            Application.Run(new FrmConnection());
        }
    }
}
