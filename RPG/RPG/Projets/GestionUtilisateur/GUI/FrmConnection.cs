using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPG.Projets.GestionUtilisateur.BLL;
using CefSharp;
using CefSharp.WinForms;
namespace RPG.Projets.GestionUtilisateur.GUI
{
    /// <summary>
    /// Classe permettant l'interaction du Formulaire.
    /// Ete 2019
    /// </summary>
   
    public partial class FrmConnection : Form
    {
        Connexion _connexion = new Connexion();
        public ChromiumWebBrowser browser;
        string _username = "";

        public FrmConnection()
        {
            InitializeComponent();
            Cef.EnableHighDPISupport();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            _username = txtUtilisateur.Text;

            if(!_connexion.Authentifier(_username, txtMotDePasse.Text))
                MessageBox.Show("Mauvais utilisateur ou mot de passe");
            else
            {
                //Lancer Game.cs
                this.Hide();
                Game game = new Game(_connexion);
                game.Show();


            }
        }

        private void FrmConnection_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser("192.168.2.49")
            {
                Dock = DockStyle.Fill,
                Size = new Size(600, 600),
                Location = new Point(200, 200),
            };
            this.panel1.Controls.Add(browser);
        }

        /// <summary>
        /// Auteur : Felix Noiseux
        /// Description : Click de l'inscription
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inscriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.Load("192.168.2.49/inscription");
        }

        private void motDePassePerduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser.Load("192.168.2.49/reset");
        }

    }
}
