using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeWebAPI_Tuesday.Model;

namespace PracticeWebAPI_Tuesday.Configuration
{
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(new Course
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
