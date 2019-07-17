using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGestion.Model.Inscription
{
    public class InscriptionModel
    {
        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Prenom { get; set; }
        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 3)]
        public string Nom { get; set; }
        [Required]
        [EmailAddress]
        public string Courriel { get; set; }
        [Required]
        [Display(Name = "Nom de connection")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public DateTime DataInscription { get; set; }
        public int TypeUtilisateur { get; set; }
    }
}
