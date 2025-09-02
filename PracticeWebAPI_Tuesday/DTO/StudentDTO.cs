using PracticeWebAPI_Tuesday.Model;

namespace PracticeWebAPI_Tuesday.DTO
{
    public class StudentDTO
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public List<EnrollmentDTO> Enrollments { get; set; } = new List<EnrollmentDTO>();
    }
}
