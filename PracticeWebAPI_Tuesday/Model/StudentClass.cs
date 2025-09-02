using System.ComponentModel.DataAnnotations;

namespace PracticeWebAPI_Tuesday.Model
{
    public class StudentClass
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public List<EnrollmentSC> Enrollments { get; set; } = new List<EnrollmentSC>();
    }
}
