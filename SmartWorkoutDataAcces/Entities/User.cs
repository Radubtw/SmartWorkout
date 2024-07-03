using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SmartWorkoutDataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; } = null!;
        [RegularExpression(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]{9}$", ErrorMessage ="Invalid Phone number")]
        public string? Phone { get; set; }
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }
        [Range(1,120,ErrorMessage = "Age should be between 1 and 120")]
        public int? Age { get; set; }
        [Range(1, 300, ErrorMessage = "Weight should be between 1 and 300")]
        public double? Weight { get; set; }

        public ICollection<Workout> Workouts { get; set; } = new HashSet<Workout>();
    }
}
