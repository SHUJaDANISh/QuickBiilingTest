using Microsoft.AspNetCore.Mvc;
using QuickBiilingTest.Models.Dto;
using QuickBiilingTest.Models.Responses;
using QuickBiilingTest.Services.Interfaces;

namespace QuickBiilingTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>> Login([FromBody] LoginDto loginDto)
        {
            var authResponse = await _authService.Login(loginDto);
            if (authResponse == null)
            {
                return Unauthorized("Invalid username or password");
            }

            return Ok(authResponse);
        }

        [HttpPost("register")]
        public async Task<ActionResult<int>> Register([FromBody] RegisterDto registerDto)
        {
            try
            {
                var userId = await _authService.Register(registerDto);
                return Ok(userId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}