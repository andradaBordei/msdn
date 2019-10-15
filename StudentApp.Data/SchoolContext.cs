using Microsoft.EntityFrameworkCore;
using StudentApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Data
{
    public class SchoolContext: DbContext
    {
        public DbSet<Course> Courses { get;set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;");
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder) {
        //    modelBuilder.Entity<Course>(entity => { entity.Property(e => e.Title).HasMaxLength(100); });
        //    modelBuilder.Entity<Student>(entity => { entity.Property(e => e.LastName).HasMaxLength(75); });
        //    }
        
    }
}
