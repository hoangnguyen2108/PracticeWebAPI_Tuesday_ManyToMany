using System.ComponentModel.DataAnnotations;

namespace PracticeWebAPI_Tuesday.Model
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public List<EnrollmentSC> Enrollments { get; set; } = new List<EnrollmentSC>();
    }
}
