//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RPG
{
    using System;
    using System.Collections.Generic;
    
    public partial class Potion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Potion()
        {
            this.PotionsJoueurs = new HashSet<PotionsJoueur>();
        }
    
        public int PotionID { get; set; }
        public string Nom { get; set; }
        public Nullable<int> PtsAttaque { get; set; }
        public Nullable<int> PtsDefense { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PotionsJoueur> PotionsJoueurs { get; set; }
    }
}