﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDMYPE_DataAcces
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_A50A07_TestAPPEntities : DbContext
    {
        public DB_A50A07_TestAPPEntities()
            : base("name=DB_A50A07_TestAPPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<GastosFijosVariable> GastosFijosVariables { get; set; }
        public virtual DbSet<ManoDeObra> ManoDeObras { get; set; }
        public virtual DbSet<Materiale> Materiales { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
