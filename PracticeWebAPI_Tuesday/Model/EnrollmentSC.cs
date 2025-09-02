using System.ComponentModel.DataAnnotations;

namespace PracticeWebAPI_Tuesday.Model
{
    public class EnrollmentSC
    {
       
        public int StudentId { get; set; }
     
        public int CourseId { get; set; }


        public StudentClass StudentClass { get; set; }
        public Course Course { get; set; }
    }
}
