using SmartWorkoutDataAccess.Entities;
using SmartWorkoutDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Repositories
{
    public interface IExercise_Log_Repository : IGenericRepository<Exercise_Log>
    {
        Task<IEnumerable<Exercise_Log>> GetExerciseLogsWithExercisesByWorkoutId(int workoutId);
        Task Delete(int  workoutId, int exerciseId);
        Task <Exercise_Log>GetExerciseLogByWorkoutAndExerciseId(int workoutId, int exerciseId);
    }
}
