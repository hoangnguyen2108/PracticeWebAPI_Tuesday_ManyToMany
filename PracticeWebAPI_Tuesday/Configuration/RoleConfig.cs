using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PracticeWebAPI_Tuesday.Configuration
{
    public class RoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
           builder.HasData(new IdentityRole
           {
               Id = "1b1bb66e-6aa2-4728-8b5b-4e6de4fd899b",
               Name = "Administrator",
               NormalizedName = "ADMINISTRATOR"
           },
   new IdentityRole
   {
       Id = "958e6340-4275-49ed-80ee-2cb5e2fad807",
       Name = "Employee",
       NormalizedName = "EMPLOYEE"
   },
   new IdentityRole
   {
       Id = "f4145e80-361d-4541-b311-9e95b4a95964",
       Name = "Supervisor",
       NormalizedName = "SUPERVISOR"
   });


        }
    }
}
