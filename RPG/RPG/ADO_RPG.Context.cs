﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RPGEntities : DbContext
    {
        public RPGEntities()
            : base("name=RPGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Arme> Armes { get; set; }
        public virtual DbSet<ArmesJoueur> ArmesJoueurs { get; set; }
        public virtual DbSet<Armure> Armures { get; set; }
        public virtual DbSet<ArmuresJoueur> ArmuresJoueurs { get; set; }
        public virtual DbSet<Hero> Heroes { get; set; }
        public virtual DbSet<Inventaire> Inventaires { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Potion> Potions { get; set; }
        public virtual DbSet<PotionsJoueur> PotionsJoueurs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TypeUtilisateur> TypeUtilisateurs { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
    }
}
