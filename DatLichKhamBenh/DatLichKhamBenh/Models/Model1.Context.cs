﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatLichKhamBenh.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebDatLichKhamBenhEntities : DbContext
    {
        public WebDatLichKhamBenhEntities()
            : base("name=WebDatLichKhamBenhEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<danhsachbacsi> danhsachbacsis { get; set; }
        public virtual DbSet<MENU> MENUs { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<datlichhen> datlichhens { get; set; }
    }
}
