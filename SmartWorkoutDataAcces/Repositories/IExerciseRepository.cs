using SmartWorkoutDataAccess.Entities;
using SmartWorkoutDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Repositories
{
    public interface IExerciseRepository : IGenericRepository<Exercise>
    {
        Task<Exercise> GetExerciseByName(string name);
        
    }
}
