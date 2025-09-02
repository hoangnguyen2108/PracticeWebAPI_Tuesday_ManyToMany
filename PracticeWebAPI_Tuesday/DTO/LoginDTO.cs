using System.ComponentModel.DataAnnotations;

namespace PracticeWebAPI_Tuesday.DTO
{
    public class LoginDTO
    {
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string PassWord { get; set; }
    }
}
