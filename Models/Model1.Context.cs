﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProy.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinalWebProyectEntities1 : DbContext
    {
        public FinalWebProyectEntities1()
            : base("name=FinalWebProyectEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<evento> evento { get; set; }
        public virtual DbSet<noticias> noticias { get; set; }
        public virtual DbSet<PagoPendiente> PagoPendiente { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
    }
}