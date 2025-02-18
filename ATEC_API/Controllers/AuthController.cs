namespace ATEC_API.Controllers
{
    using ATEC_API.Data.Context;
    using ATEC_API.Data.DTO.AuthDTO;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Text;

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(UserManager<ApplicationUser> _userManager) : ControllerBase
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthDTO authDTO)
        {
            var user = await _userManager.FindByNameAsync(authDTO.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, authDTO.Password))
            {
                var token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{authDTO.UserName}:{authDTO.Password}"));
                return Ok(new { Token = token });
            };
            return Unauthorized();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] AuthDTO authDTO)
        {
            var user = new ApplicationUser { UserName = authDTO.UserName };
            var result = await _userManager.CreateAsync(user, authDTO.Password);

            if (result.Succeeded)
            {
                return Ok(new { Message = "User registered successfully" });
            }

            return BadRequest(result.Errors);
        }
    }
}
