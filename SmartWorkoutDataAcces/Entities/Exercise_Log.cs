using Microsoft.EntityFrameworkCore.Query;
using SmartWorkoutDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Entities
{
    public class Exercise_Log
    {
        public int Workout_Id { get; set; }
        public int Exercise_Id { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Weight can only be positive!")]
        public double? Weight { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Sets can only be positive!")]
        public int? Sets { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Reps can only be positive!")]
        public int? Reps { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Duration can only be positive!")]
        public int? Duration { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Distance can only be positive!")]
        public int? Distance { get; set; }
        public Workout Workout { get; set; } = null!;
        public Exercise Exercise { get; set; } = null!;
    }
}
