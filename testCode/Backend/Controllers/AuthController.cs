using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;


namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            var user = await _context.MsUsers
                .FirstOrDefaultAsync(u => u.user_name == username && u.password == password);

            if (user == null || !user.is_active)
                return Unauthorized("Invalid credentials or inactive user.");

            return Ok(new { user.user_id, user.user_name });
        }
    }
}
