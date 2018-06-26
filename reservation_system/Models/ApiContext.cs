using System;
using Microsoft.EntityFrameworkCore;

namespace reservation_system.Models
{
    public class ApiContext : DbContext
    {
        public DbSet<Provider> Providers {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<Tag> Tags { get; set; }

        public ApiContext(DbContextOptions<ApiContext> o) : base(o) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>(entity => {
                entity.ToTable("providers");
                entity.HasKey(e => e.Id).HasName("id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.Criteria).HasColumnName("criteria");
                entity.Property(e => e.Discription).HasColumnName("discription");
                entity.Property(e => e.Password).HasColumnName("password");
                entity.HasMany(e => e.Tags).WithOne(f => f.Provider).HasForeignKey("provider_id");
                entity.HasMany(e => e.Reservations).WithOne(f => f.Provider).HasForeignKey("provider_id");
            });

            modelBuilder.Entity<User>(entity => {
                entity.ToTable("users");
                entity.HasKey(e => e.Id).HasName("id");
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.Password).HasColumnName("password");
                entity.HasMany(e => e.Reservations);
            });
            
            modelBuilder.Entity<Tag>(entity => {
                entity.ToTable("tag");
                entity.HasKey(e => e.Id).HasName("id");
                entity.Property(e => e.Name).HasColumnName("name");
            });
            
            modelBuilder.Entity<Reservation>(entity => {
                entity.ToTable("Reservations");
                entity.HasKey(e => e.Id).HasName("id");
                entity.Property(e => e.StartTime).HasColumnName("start_time");
                entity.Property(e => e.Duration).HasColumnName("duration");
                entity.Property(e => e.UserId).HasColumnName("user_id");
            });
        }
    }
}