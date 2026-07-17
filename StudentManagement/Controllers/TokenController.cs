using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Data;
using StudentManagement.DTOs;
using StudentManagement.Services;

namespace StudentManagement.Controllers
{
    [ApiController]
    [Route("token")]
    public class TokenController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly JwtService _jwtService;
        private readonly PasswordService _passwordService;

        public TokenController(
            AppDbContext context,
            JwtService jwtService,
            PasswordService passwordService)
        {
            _context = context;
            _jwtService = jwtService;
            _passwordService = passwordService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(
            LoginRequest request)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(x =>
                    x.UserLogin == request.Login);

            if (user == null)
                return Unauthorized();

            var isValid = _passwordService.VerifyPassword(
                user,
                user.UserPassword,
                request.Password);

            if (!isValid)
                return Unauthorized();

            var token =
                _jwtService.GenerateToken(user.UserLogin);

            return Ok(new LoginResponse
            {
                Token = token
            });
        }
    }
}
