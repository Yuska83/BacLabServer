﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BacLabServer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BacLab_DBEntities : DbContext
    {
        public BacLab_DBEntities()
            : base("name=BacLab_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Antibiotic> Antibiotics { get; set; }
        public virtual DbSet<Antibiotics_groups> Antibiotics_groups { get; set; }
        public virtual DbSet<Category_of_patient> Category_of_patient { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Diagnosi> Diagnosis { get; set; }
        public virtual DbSet<Identification_Table> Identification_Table { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
        public virtual DbSet<Microorganism> Microorganisms { get; set; }
        public virtual DbSet<Microorganisms_groups> Microorganisms_groups { get; set; }
        public virtual DbSet<Microscopy> Microscopies { get; set; }
        public virtual DbSet<Olkenickiy> Olkenickiys { get; set; }
        public virtual DbSet<p_AB_MO_group_profile> p_AB_MO_group_profile { get; set; }
        public virtual DbSet<p_Study_CategoryPatient> p_Study_CategoryPatient { get; set; }
        public virtual DbSet<Purpose_of_study> Purpose_of_study { get; set; }
        public virtual DbSet<Research_group> Research_group { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Staff_category> Staff_category { get; set; }
        public virtual DbSet<Template_Results> Template_Results { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<TestSet> TestSets { get; set; }
        public virtual DbSet<Type_Colonyy> Type_Colonyy { get; set; }
        public virtual DbSet<Variant> Variants { get; set; }
    }
}
