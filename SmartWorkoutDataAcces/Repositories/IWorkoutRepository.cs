using SmartWorkoutDataAccess.Entities;
using SmartWorkoutDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Repositories
{
    public interface IWorkoutRepository : IGenericRepository<Workout>
    {
        Task<IEnumerable<Workout>> GetWorkoutsByUserId(int userId);
    }
}
