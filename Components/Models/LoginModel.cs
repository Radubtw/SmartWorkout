using System.ComponentModel.DataAnnotations;

namespace SmartWorkout.Components.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email required!")]
        public string? Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password required!")]
        public string? Password { get; set; }
    }

}
