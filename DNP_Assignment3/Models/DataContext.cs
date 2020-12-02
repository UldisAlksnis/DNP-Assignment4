using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNP_Assignment3.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=b9oaptwo7jahaixr2kyr-postgresql.services.clever-cloud.com;Database=b9oaptwo7jahaixr2kyr;Username=ufxdpdo5phqqd3bjrk1u;Password=k9cI75OgnkgGZVZqR18R;");
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Adult> Adults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adult>(entity =>
            {
                entity.ToTable("adult", "assignment4");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.EyeColor)
                    .HasColumnType("character varying")
                    .HasColumnName("eye_color");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("firstName");

                entity.Property(e => e.HairColor)
                    .HasColumnType("character varying")
                    .HasColumnName("hair_color");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.JobTitle)
                    .HasColumnType("character varying")
                    .HasColumnName("job_title");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("last_name");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("sex");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("user", "assignment4");

                entity.Property(e => e.BirthYear).HasColumnName("birthYear");

                entity.Property(e => e.City)
                    .HasColumnType("character varying")
                    .HasColumnName("city");


                entity.Property(e => e.Domain)
                    .HasColumnType("character varying")
                    .HasColumnName("domain");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .HasColumnType("character varying")
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasColumnType("character varying")
                    .HasColumnName("role");

                entity.Property(e => e.SecurityLevel).HasColumnName("securityLevel");

                entity.Property(e => e.UserName)
                    .HasColumnType("character varying")
                    .HasColumnName("username");
            });
        }
    }
}
