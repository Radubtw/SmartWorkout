using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Entities
{
    public class Workout
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Duration can only be positive!")]
        public int? Duration { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }
        public User User { get; set; } = null!;
        public ICollection<Exercise_Log> Exercise_Logs { get; set; } = new HashSet<Exercise_Log>();
    }
}
