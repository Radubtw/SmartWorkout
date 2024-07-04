using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SmartWorkoutDataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"[A-Za-z]{1,40}", ErrorMessage = "Invalid name")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Surname is required")]
        [RegularExpression(@"[A-Za-z]{1,40}", ErrorMessage = "Invalid surname")]
        public string Surname { get; set; } = null!;
        [RegularExpression(@"^[\+]?[(]?[0-9]{1,3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$", ErrorMessage ="Invalid Phone number")]
        public string? Phone { get; set; }
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }
        [Range(1,120,ErrorMessage = "Age should be between 1 and 120")]
        public int? Age { get; set; }
        [Range(1, 300, ErrorMessage = "Weight should be between 1 and 300")]
        public double? Weight { get; set; }
        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();
    }
}