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

                optionsBuilder.UseSqlServer("Server=DESKTOP-BDMLIR6;Database=AnimalRescue;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animals>(entity =>
            {
                entity.HasKey(e => e.AnimalId)
                    .HasName("PK__Animals__A21A7307B78DEB17");

                entity.Property(e => e.AnimalBreed).HasMaxLength(20);

                entity.Property(e => e.AnimalGender).HasMaxLength(6);

                entity.Property(e => e.AnimalName).HasMaxLength(30);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04F11A6431903");

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastName).HasMaxLength(30);

                entity.Property(e => e.Position).HasMaxLength(30);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.AnimalId)
                    .HasConstraintName("FK__Employees__Anima__49C3F6B7");

                entity.HasOne(d => d.Volunteer)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.VolunteerId)
                    .HasConstraintName("FK__Employees__Volun__48CFD27E");
            });

            modelBuilder.Entity<Volunteers>(entity =>
            {
                entity.HasKey(e => e.VolunteerId)
                    .HasName("PK__Voluntee__716F6F2C7FB85DFC");

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastName).HasMaxLength(30);

                entity.Property(e => e.Position).HasMaxLength(30);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Animal)
                    .WithMany(p => p.Volunteers)
                    .HasForeignKey(d => d.AnimalId)
                    .HasConstraintName("FK__Volunteer__Anima__45F365D3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
