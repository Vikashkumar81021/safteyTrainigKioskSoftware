using System.ComponentModel.DataAnnotations;

namespace Safety_Training_Kiosk_Software.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string EmployeeId { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string FullName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Department { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Email { get; set; }

        [Required, MaxLength(20)]
        public string Role { get; set; } = "Trainee";

        public string? PasswordHash { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}