using Microsoft.EntityFrameworkCore.Query;
using SmartWorkoutDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;


namespace SmartWorkoutDataAccess.Entities
{
    public class Exercise
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"[A-Za-z\s]{1,25}", ErrorMessage = "Invalid name")]
        public string Name { get; set; } = null!;
        public ICollection<Exercise_Log> Exercise_Logs { get; set; } = new HashSet<Exercise_Log>();
    }
}
