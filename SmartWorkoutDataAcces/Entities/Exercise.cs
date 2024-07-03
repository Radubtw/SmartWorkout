using Microsoft.EntityFrameworkCore.Query;
using SmartWorkoutDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Entities
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Exercise_Log> Exercise_Logs { get; set; } = new HashSet<Exercise_Log>();
    }
}
