using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PracticeWebAPI_Tuesday.DTO;
using PracticeWebAPI_Tuesday.User;

namespace PracticeWebAPI_Tuesday.Service
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<ApiUser> _manager;

        public AccountService(UserManager<ApiUser> manager)
        {
            _manager = manager;
        }

        [HttpPost]
        public async Task<bool> Register(UserDTO userDTO)
        {
            var model = new ApiUser
            {
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                UserName = userDTO.EmailAddress,
                Email = userDTO.EmailAddress
            };

            var updated = await _manager.AddPasswordAsync(model, userDTO.PassWord);

            if (updated.Succeeded)
            {
                await _manager.AddToRoleAsync(model, "Employee");
                return true;
            }
            return false;
        }

        [HttpPost]

        public async Task<bool> Login(LoginDTO loginDTO)
        {
            var product = await _manager.FindByEmailAsync(loginDTO.EmailAddress);

            if (product == null)
            {
                return false;
            }

            var model = await _manager.CheckPasswordAsync(product, loginDTO.PassWord);

            if (model)
            {
                return true;
            }
            return false;
        }
    }


}