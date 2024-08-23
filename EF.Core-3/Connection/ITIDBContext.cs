using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Core_3.Classes;

namespace EF_Core_3.Connection
{
    internal class ITIDBContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database= ITI1; Trusted_Connection = true ; Encrypt = False");
        }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Stud_Course> stud_Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                        .HasMany(s => s.Stud_Courses)
                        .WithOne(s=>s.Student);

            modelBuilder.Entity<Course>()
                        .HasMany(c=>c.Stud_Courses)
                        .WithOne(c=>c.course);

            modelBuilder.Entity<Instructor>()
                        .HasMany(i=>i.course_Insts)
                        .WithOne(i=>i.instructor);

            modelBuilder.Entity<Course>()
                        .HasMany(c => c.Course_Insts)
                        .WithOne(c => c.course);

            modelBuilder.Entity<Course_Inst>()
                        .HasKey(ci => new { ci.CourseID, ci.InstructorID });

            modelBuilder.Entity<Stud_Course>()
                        .HasKey(sc =>new {sc.CourseID,sc.StudentID} );
            
        }
    }
    
    
}
