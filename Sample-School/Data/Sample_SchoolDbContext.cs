using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ContosoUniversity.Data
{
    public class Sample_SchoolDbContext: DbContext
    {
        public Sample_SchoolDbContext(DbContextOptions<Sample_SchoolDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}