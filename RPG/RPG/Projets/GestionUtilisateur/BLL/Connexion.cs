using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Projets.GestionUtilisateur.DAL;

namespace RPG.Projets.GestionUtilisateur.BLL
{
   public class Connexion
    {
        public DatabaseAccess DbAccess;

        public Connexion()
        {
            DbAccess = new DatabaseAccess();
            DbAccess.ChargerUtilisateurs();
        }
        public bool Authentifier(string username, string password)
        {
            if (username == "" || password == "")
                return false;

           return DbAccess.Connection(username, password);
        }
    }
}
