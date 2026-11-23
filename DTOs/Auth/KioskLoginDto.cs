using System.ComponentModel.DataAnnotations;

namespace Safety_Training_Kiosk_Software.DTOs.Auth
{
    public class KioskLoginDto
    {
        [Required]
        public string EmployeeId { get; set; } = string.Empty;
    }
}