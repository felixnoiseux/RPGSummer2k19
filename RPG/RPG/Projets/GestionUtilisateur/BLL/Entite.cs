using RPG.Projets.GestionUtilisateur.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Projets.GestionUtilisateur.BLL
{
    /// <summary>
    /// Classe permettant l'acces aux divers objets de la BD.
    /// </summary>
    public class Entite
    {
        DatabaseAccess _DBAccess;
        public Entite(DatabaseAccess DBAccess)
        {
            _DBAccess = DBAccess;
        }
        public Utilisateur RecevoirUtilisateur()
        {
            return _DBAccess.RecevoirUtilisateur();
        }
    }
}
