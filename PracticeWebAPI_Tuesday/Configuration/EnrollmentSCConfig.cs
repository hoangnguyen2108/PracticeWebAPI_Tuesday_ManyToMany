using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PracticeWebAPI_Tuesday.Model;

namespace PracticeWebAPI_Tuesday.Configuration
{
    public class EnrollmentSCConfig : IEntityTypeConfiguration<EnrollmentSC>
    {
        public void Configure(EntityTypeBuilder<EnrollmentSC> builder)
        {
            builder.HasData(new EnrollmentSC
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
        }
    }
}
