using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PracticeWebAPI_Tuesday.DTO;
using PracticeWebAPI_Tuesday.Service;
using PracticeWebAPI_Tuesday.User;

namespace PracticeWebAPI_Tuesday.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly IAccountService _accountService;

        public AccountController(UserManager<ApiUser> userManager, IAccountService accountService)
        {
            _userManager = userManager;
            _accountService = accountService;
        }



        [HttpPost]
        [Route("Register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register(UserDTO userDTO)
        {
            var update = await _accountService.Register(userDTO);
            if (!update)
            {
                return BadRequest("Failed to Register");
            }
            return Ok("Register Success");
        }

        [HttpPost]
        [Route("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Login(LoginDTO loginDTO)
        {
            var update = await _accountService.Login(loginDTO);
            if (!update)
            {
                return BadRequest("Failed to Login");
            }
            return Ok("Register Success");
        }
    }
        
}
