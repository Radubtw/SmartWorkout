using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Entities
{
    public class Workout
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? Duration { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; } = null!;
        public ICollection<Exercise_Log> Exercise_Logs { get; set; } = new HashSet<Exercise_Log>();
    }
}
