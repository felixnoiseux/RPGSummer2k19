using RPG.Projets.GestionUtilisateur.BLL;
using RPG.Projets.GestionUtilisateur.DAL;
using RPG.Projets.Jeu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG.Projets.GestionUtilisateur.GUI
{
    public partial class Game : Form
    {

        Utilisateur _utilisateur;
        Hero _hero;
        Connexion _connexion;
        Entite _entite;
        List<Hero> lstHeros = new List<Hero>();

        public Game(Connexion connexion)
        {
            _connexion = connexion;
            _utilisateur = new Utilisateur();
            _hero = new Hero();
            _entite = new Entite(_connexion.DbAccess);

            _utilisateur = _entite.RecevoirUtilisateur();
            _hero = _utilisateur.Heroes.FirstOrDefault();
            InitializeComponent();
            lblUsername.Text = _utilisateur.Username;

            //Ajout des heros au combobox.
            lstHeros = _utilisateur.Heroes.ToList();

            for (int i = 0; i < lstHeros.Count; i++)
            {
                cmbHeros.Items.Add(lstHeros[i].Utilisateur.Nom);
            }
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            Jeu.RPGGame jeu = new RPGGame(_hero);
            jeu.Show();
        }

        private void btnInfoHero_Click(object sender, EventArgs e)
        {

        }
    }
}
