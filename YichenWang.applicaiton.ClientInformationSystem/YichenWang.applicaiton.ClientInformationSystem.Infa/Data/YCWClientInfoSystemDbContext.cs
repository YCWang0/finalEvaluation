using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using YichenWang.applicaiton.ClientInformationSystem.Core.Entities;

namespace YichenWang.applicaiton.ClientInformationSystem.Infa.Data
{
    public class YCWClientInfoSystemDbContext : DbContext
    {
        public YCWClientInfoSystemDbContext(DbContextOptions<YCWClientInfoSystemDbContext> options) : base(options)
        {
        }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Interactions> Interactions { get; set; }
        public DbSet<Clients> Clients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(ConfigureEmployees);
            modelBuilder.Entity<Interactions>(ConfigureInteractions);
            modelBuilder.Entity<Clients>(ConfigureClients);
        }

        private void ConfigureClients(EntityTypeBuilder<Clients> modelBuilder)
        {
            modelBuilder.ToTable("Clients");
            modelBuilder.HasKey(c => c.Id);
            modelBuilder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Property(c => c.Email).IsRequired().HasMaxLength(50);
            modelBuilder.Property(c => c.Phones).IsRequired().HasMaxLength(30);
            modelBuilder.Property(c => c.Address).IsRequired().HasMaxLength(100);
            modelBuilder.Property(c => c.AddedOn).IsRequired();
        }

        private void ConfigureInteractions(EntityTypeBuilder<Interactions> modelBuilder)
        {
            modelBuilder.ToTable("Interactions");
            modelBuilder.HasKey(i => i.Id);
            modelBuilder.Property(i => i.ClientId).IsRequired();
            modelBuilder.Property(i => i.EmpId).IsRequired();
            modelBuilder.Property(i => i.IntType).IsRequired().HasMaxLength(1);
            modelBuilder.Property(i => i.IntDate).IsRequired();
            modelBuilder.Property(i => i.Remarks).IsRequired().HasMaxLength(500);

        }

        private void ConfigureEmployees(EntityTypeBuilder<Employees> modelBuilder)
        {
            modelBuilder.ToTable("Employees");
            modelBuilder.HasKey(e => e.Id);
            modelBuilder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            modelBuilder.Property(e => e.Password).IsRequired().HasMaxLength(10);
            modelBuilder.Property(e => e.Designation).IsRequired().HasMaxLength(50);
        }
    }
}
