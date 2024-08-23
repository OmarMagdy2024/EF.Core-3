using Demo.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ITIDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ITI ; Trusted_Connection = true ; Encrypt = False");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CouseStudent> StudentCouses { get; set; }
        //public DbSet<FullTime> FullTime { get; set; }
        //public DbSet<Parttime> Parttime { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Student>()
            //            .HasMany(s => s.Courses)
            //            .WithMany(c => c.students);

            //modelBuilder.Entity<Course>()
            //            .HasMany(c => c.students)
            //            .WithMany(s => s.Courses);

            modelBuilder.Entity<Student>()
                        .HasMany(s => s.couseStudents)
                        .WithOne(s  => s.student);

            modelBuilder.Entity<Course>()
                        .HasMany(c => c.couseStudents)
                        .WithOne(s => s.course);

            modelBuilder.Entity<CouseStudent>()
                        .HasKey(sc => new{ sc.StudentId,sc.CourseId});

            modelBuilder.Entity<FullTime>()
                        .Property(f => f.Salary)
                        .HasColumnType("decimal(18,3)");

            modelBuilder.Entity<FullTime>()
                        .HasBaseType<Employee>();

            modelBuilder.Entity<Parttime>()
                        .HasBaseType<Employee>();
        }
    }
}
