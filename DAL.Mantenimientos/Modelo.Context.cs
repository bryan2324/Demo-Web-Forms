﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Mantenimientos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VehiculosEntities : DbContext
    {
        public VehiculosEntities()
            : base("name=VehiculosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bikes> Bikes { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Owners> Owners { get; set; }
        public virtual DbSet<Planes> Planes { get; set; }
    }
}
