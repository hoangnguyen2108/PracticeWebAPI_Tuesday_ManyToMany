using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using PracticeWebAPI_Tuesday.Model;

namespace PracticeWebAPI_Tuesday.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<StudentClass> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<EnrollmentSC> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EnrollmentSC>().
                HasKey(c => new {c.StudentId, c.CourseId});

            modelBuilder.Entity<EnrollmentSC>()
                .HasOne(c => c.StudentClass)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(c => c.StudentId);

            modelBuilder.Entity<EnrollmentSC>()
                .HasOne(c => c.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<EnrollmentSC>().HasData(new EnrollmentSC
            {
                StudentId = 1,
                CourseId = 1
            }, new EnrollmentSC
            {
                StudentId = 1,
                CourseId = 2
            }, new EnrollmentSC
            {
                StudentId = 2,
                CourseId = 1
            });
            modelBuilder.Entity<StudentClass>()
                .HasData(new StudentClass
                {
                    StudentId = 1,
                    StudentName = "Studnet1",
                    DateOfBirth = new DateOnly(1999, 09, 19)
                    
                },new StudentClass
                {
                    StudentId = 2,
                    StudentName = "Student2",
                    DateOfBirth = new DateOnly(2000,10,20)
                },new StudentClass
                {
                    StudentId = 3,
                    StudentName = "Student3",
                    DateOfBirth = new DateOnly(2001,11,21)
                });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                CourseId = 1,
                CourseName = "Course1",

            }, new Course
            {
                CourseId = 2,
                CourseName = "Course2"
            });

                
        }
    }
}
