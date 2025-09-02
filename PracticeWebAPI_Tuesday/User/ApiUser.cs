using Microsoft.AspNetCore.Identity;

namespace PracticeWebAPI_Tuesday.User
{
    public class ApiUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }
}
