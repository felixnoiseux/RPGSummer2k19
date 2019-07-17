using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Projets.GestionUtilisateur.BLL;

namespace RPG.Projets.GestionUtilisateur.DAL
{
    /// <summary>
    /// Classe donnant acces 
    /// </summary>
    public class DatabaseAccess
    {
        RPGEntities entities = new RPGEntities();
        List<Utilisateur> lstUtilisateurs = new List<Utilisateur>();
        Utilisateur utilisateur;

        public void ChargerUtilisateurs()
        {
            foreach (Utilisateur utilisateur in entities.Utilisateurs)
                lstUtilisateurs.Add(utilisateur);
        }
        public bool Connection(string username, string password)
        {
            utilisateur = new Utilisateur();
            utilisateur = (Utilisateur)lstUtilisateurs.Where(x => x.Username == username).FirstOrDefault();

            //Utilisateur inexistant
            if (utilisateur == null)
                return false;

            string mdp = "";
            string salt = "";
            bool isSalt = false;
            for(int i = 0; i < utilisateur.MotDePasse.Length; i++)
            {
                if (utilisateur.MotDePasse[i] == ':' && !isSalt)
                    isSalt = true;
                else if (isSalt)
                    salt += utilisateur.MotDePasse[i];
                else
                    mdp += utilisateur.MotDePasse[i];
            }

            string passwordEntre = Securite.GenerateSHA256String(password + salt);
            if (mdp != passwordEntre)
                return false;
            else
                return true;
        }

        public Utilisateur RecevoirUtilisateur()
        {
            return utilisateur;
        }
    }
}
