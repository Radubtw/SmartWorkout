using Microsoft.EntityFrameworkCore.Query;
using SmartWorkoutDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Entities
{
    public class Exercise_Log
    {
        public int Workout_Id { get; set; }
        public int Exercise_Id { get; set; }
        public double? Weight { get; set; }
        public int? Sets { get; set; }
        public int? Reps { get; set; }
        public int? Duration { get; set; }
        public int? Distance { get; set; }
        public Workout Workout { get; set; } = null!;
        public Exercise Exercise { get; set; } = null!;
    }
}
