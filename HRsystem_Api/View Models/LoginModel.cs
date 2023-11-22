using System.ComponentModel.DataAnnotations;

namespace HRsystem_Api.Controllers
{
    public class LoginModel
    {
        [Required]
        public string? UserName { get; set; }
        
    }
}