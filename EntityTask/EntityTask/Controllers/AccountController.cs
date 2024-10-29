using EntityTask.DATA.Entity;
using EntityTask.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EntityTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<UserIdentity> _userManager;
        private readonly SignInManager<UserIdentity> _signInManager;

        public AccountController(UserManager<UserIdentity> userManager, SignInManager<UserIdentity> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO login)
        {
            var user = await _userManager.FindByEmailAsync(login.Email);
            if (user == null)
            {
                return BadRequest("User not found.");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, login.Password, false);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return Ok();
            }
            else
            {
                return BadRequest("Invalid password.");
            }
        }
        [HttpGet("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }
    }
}
