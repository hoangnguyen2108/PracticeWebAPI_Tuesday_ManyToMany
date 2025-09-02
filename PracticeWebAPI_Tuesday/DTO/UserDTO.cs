using System.ComponentModel.DataAnnotations;

namespace PracticeWebAPI_Tuesday.DTO
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        

        [EmailAddress]
        public string EmailAddress { get; set; }
        public string PassWord { get; set; }
    }
}
