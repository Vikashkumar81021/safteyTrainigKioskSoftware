using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Safety_Training_Kiosk_Software.Data;
using Safety_Training_Kiosk_Software.Models;

namespace Safety_Training_Kiosk_Software
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Resgister([FromBody] User user)
        {
            if (await _context.Users.AnyAsync(U => U.EmployeeId == user.EmployeeId))
                return BadRequest(new { message = "Employee Already registred" });
            if (!string.IsNullOrEmpty(user.PasswordHash))
                user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(new { message = "User creation successfully", user });
        }
        [HttpGet]
        public async Task<IActionResult>getAllUsers()
        {
            var users = await _context.Users
            .Select(u => new { u.Id, u.EmployeeId, u.FullName, u.Department, u.Role, u.CreatedAt })
            .ToListAsync();

            return Ok(users);
        }
    }
};