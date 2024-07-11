using SmartWorkoutDataAccess.Entities;
using SmartWorkoutDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> GetUserByName(string name);
        Task<User> GetUserBySurname(string surname);
        Task<IEnumerable<User>> GetUsersByTrainerId(int id);
    }
}
