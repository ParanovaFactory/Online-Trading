﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Satış
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class İşletmeEntities : DbContext
    {
        public İşletmeEntities()
            : base("name=İşletmeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblkategori> tblkategori { get; set; }
        public virtual DbSet<tblmusteri> tblmusteri { get; set; }
        public virtual DbSet<tblsatis> tblsatis { get; set; }
        public virtual DbSet<tblurun> tblurun { get; set; }
        public virtual DbSet<tbladmin> tbladmin { get; set; }
    
        public virtual ObjectResult<string> MarkaGetir()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("MarkaGetir");
        }
    }
}