using PracticeWebAPI_Tuesday.DTO;

namespace PracticeWebAPI_Tuesday.Service
{
    public interface IAccountService
    {
        Task<bool> Login(LoginDTO loginDTO);
        Task<bool> Register(UserDTO userDTO);
    }
}