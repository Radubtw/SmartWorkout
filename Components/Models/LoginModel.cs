using System.ComponentModel.DataAnnotations;

namespace SmartWorkout.Components.Models
{
    public class LoginModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }

}
