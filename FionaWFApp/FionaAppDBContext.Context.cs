﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FionaWFApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FionaWFAppBDEntities : DbContext
    {
        public FionaWFAppBDEntities()
            : base("name=FionaWFAppBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Persona> Persona { get; set; }
    
        public virtual ObjectResult<SPUltimaPersona_Result> SPUltimaPersona()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPUltimaPersona_Result>("SPUltimaPersona");
        }
    }
}
