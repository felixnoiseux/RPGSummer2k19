using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebGestion.Model.Reset
{
    public class ResetModel
    {
        [Required]
        [EmailAddress]
        public string Courriel { get; set; }
        [Required]
        [Display(Name = "Nom de connection")]
        public string Username { get; set; }
    }
}
