using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StudentAPI.Models
{
    public partial class StudentContext : DbContext
    {
        public StudentContext()
        {
        }
        public StudentContext(DbContextOptions<StudentContext> options)
           : base(options)
        {
        }

        public virtual DbSet<StudentDetail> StudentDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=student;Username=postgres;Password=15Nov1998");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("adminpack")
                .HasAnnotation("Relational:Collation", "English_United States.1252");
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}

