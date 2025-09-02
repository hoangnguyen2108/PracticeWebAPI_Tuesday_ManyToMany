using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeWebAPI_Tuesday.Model;

namespace PracticeWebAPI_Tuesday.Configuration
{
    public class StudentClassConfig : IEntityTypeConfiguration<StudentClass>
    {
        public void Configure(EntityTypeBuilder<StudentClass> builder)
        {
            builder.HasData(new StudentClass
            {
                StudentId = 1,
                StudentName = "Studnet1",
                DateOfBirth = new DateOnly(1999, 09, 19)

            }, new StudentClass
            {
                StudentId = 2,
                StudentName = "Student2",
                DateOfBirth = new DateOnly(2000, 10, 20)
            }, new StudentClass
            {
                StudentId = 3,
                StudentName = "Student3",
                DateOfBirth = new DateOnly(2001, 11, 21)
            });
        }
    }
}
