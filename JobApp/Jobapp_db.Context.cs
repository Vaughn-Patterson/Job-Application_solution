﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Jobapp_dbEntities : DbContext
    {
        public Jobapp_dbEntities()
            : base("name=Jobapp_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employer_details> Employer_details { get; set; }
        public virtual DbSet<Job_Applications_details> Job_Applications_details { get; set; }
        public virtual DbSet<Jobseeker_details> Jobseeker_details { get; set; }
        public virtual DbSet<Resume_details> Resume_details { get; set; }
        public virtual DbSet<Vacancy_details> Vacancy_details { get; set; }
    }
}
