﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consola.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SISTEMA_ANTECEDENTEEntities : DbContext
    {
        public SISTEMA_ANTECEDENTEEntities()
            : base("name=SISTEMA_ANTECEDENTEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MENU> MENU { get; set; }
        public virtual DbSet<PERMISOS> PERMISOS { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}
