﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LUSSISADTeam10API.Models.DBModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LUSSISEntities : DbContext
    {
        public LUSSISEntities()
            : base("name=LUSSISEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<adjustment> adjustments { get; set; }
        public virtual DbSet<adjustmentdetail> adjustmentdetails { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<collectionpoint> collectionpoints { get; set; }
        public virtual DbSet<delegation> delegations { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<departmentcollectionpoint> departmentcollectionpoints { get; set; }
        public virtual DbSet<disbursement> disbursements { get; set; }
        public virtual DbSet<disbursementdetail> disbursementdetails { get; set; }
        public virtual DbSet<inventory> inventories { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<lockercollectionpoint> lockercollectionpoints { get; set; }
        public virtual DbSet<outstandingrequisition> outstandingrequisitions { get; set; }
        public virtual DbSet<outstandingrequisitiondetail> outstandingrequisitiondetails { get; set; }
        public virtual DbSet<purchaseorder> purchaseorders { get; set; }
        public virtual DbSet<purchaseorderdetail> purchaseorderdetails { get; set; }
        public virtual DbSet<requisition> requisitions { get; set; }
        public virtual DbSet<requisitiondetail> requisitiondetails { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<supplieritem> supplieritems { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
