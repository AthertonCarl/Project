using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace YourPetPortfolio.Models
{
    public partial class AnimalRescueContext : DbContext
    {
        public AnimalRescueContext()
        {
        }

        public AnimalRescueContext(DbContextOptions<AnimalRescueContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animals> Animals { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Volunteers> Volunteers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-BDMLIR6;Database=AnimalRescue;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animals>(entity =>
            {
                entity.HasKey(e => e.AnimalId)
                    .HasName("PK__Animals__A21A7307D15688C1");

                entity.Property(e => e.AnimalBreed).HasMaxLength(20);

                entity.Property(e => e.AnimalGender).HasMaxLength(6);

                entity.Property(e => e.AnimalName).HasMaxLength(30);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04F11A77205D7");

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastName).HasMaxLength(30);

                entity.Property(e => e.Position).HasMaxLength(30);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<Volunteers>(entity =>
            {
                entity.HasKey(e => e.VolunteerId)
                    .HasName("PK__Voluntee__716F6F2CFE154C3D");

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastName).HasMaxLength(30);

                entity.Property(e => e.Position).HasMaxLength(30);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
