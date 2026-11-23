using System.ComponentModel.DataAnnotations;

namespace Safety_Training_Kiosk_Software.DTOs.Auth
{
    public class AdminLoginDto
    {
        [Required]
        public string Identifier { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}