using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VNR_InternShipApp.Models
{
    public class VNRDbContext : DbContext {
        public VNRDbContext() : base("name=VNRDbContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhoaHoc>().ToTable("KhoaHoc", "dbo");
            modelBuilder.Entity<MonHoc>().ToTable("MonHoc", "dbo");
        }

        public DbSet<KhoaHoc> KhoaHocs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
    }
    
}