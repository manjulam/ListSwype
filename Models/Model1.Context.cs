﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListSwype.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class listswypeEntities : DbContext
    {
        public listswypeEntities()
            : base("name=listswypeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<commonlist> commonlists { get; set; }
        public DbSet<customlist> customlists { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<userconnection> userconnections { get; set; }
        public DbSet<userlist> userlists { get; set; }
        public DbSet<userlocation> userlocations { get; set; }
    }
}
