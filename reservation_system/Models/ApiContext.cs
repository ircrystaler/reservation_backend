using System;
using Microsoft.EntityFrameworkCore;

namespace reservation_system.Models
{
    public class ApiContext : DbContext
    {
        public DbSet<Provider> Providers {get;set;}
        public DbSet<User> Users {get;set;}
        public ApiContext(DbContextOptions<ApiContext> o) : base(o) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>(entity => {
                entity.ToTable("providers");
                entity.HasKey(e => e.Id).HasName("id");
                entity.Property(e => e.FirstName).HasColumnName("first_name");
                entity.Property(e => e.FamilyName).HasColumnName("family_name");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.Password).HasColumnName("password");
            });

            modelBuilder.Entity<User>(entity => {
                entity.ToTable("users");
                entity.HasKey(e => e.Id).HasName("id");
                entity.Property(e => e.FirstName).HasColumnName("first_name");
                entity.Property(e => e.FamilyName).HasColumnName("family_name");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.Password).HasColumnName("password");
            });

            
        }
    }
}