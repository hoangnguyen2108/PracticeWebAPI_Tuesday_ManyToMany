using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using PracticeWebAPI_Tuesday.Configuration;
using PracticeWebAPI_Tuesday.Model;
using PracticeWebAPI_Tuesday.User;

namespace PracticeWebAPI_Tuesday.Data
{
    public class ApplicationDbContext: IdentityDbContext<ApiUser>
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

            modelBuilder.ApplyConfiguration(new EnrollmentSCConfig());
            modelBuilder.ApplyConfiguration(new StudentClassConfig());
            modelBuilder.ApplyConfiguration(new CourseConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());

                
        }
    }
}
