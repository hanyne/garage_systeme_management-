﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp3
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GarageEntities : DbContext
    {
        public GarageEntities()
            : base("name=GarageEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Employes> Employes { get; set; }
        public virtual DbSet<Fournisseurs> Fournisseurs { get; set; }
        public virtual DbSet<LigneReparation> LigneReparation { get; set; }
        public virtual DbSet<PiecesDetachees> PiecesDetachees { get; set; }
        public virtual DbSet<Reparations> Reparations { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Utilisateurs> Utilisateurs { get; set; }
        public virtual DbSet<Vehicules> Vehicules { get; set; }
    }
}
