using SmartWorkoutDataAccess.Entities;
using SmartWorkoutDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Frozen;

namespace SmartWorkoutDataAccess.Repositories 
{

    public class UserRepository : IUserRepository
    {
        private SmartWorkoutContext context;
        public UserRepository()
        {
            context  = new SmartWorkoutContext();
        }
        public void IDisposable()
        {
            return;
        }
        public void Save()
        {
           context.SaveChangesAsync();
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            return await context.Users.ToArrayAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await context.Users.FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<User> GetUserByName(string name)
        {
            return await context.Users.FirstOrDefaultAsync(e => string.Equals(e.Name, name));
        }
        public async Task<User> GetUserBySurname(string surname)
        {
            return await context.Users.FirstOrDefaultAsync(e => string.Equals(e.Surname, surname));
        }
        public async Task<User> Add(User user)
        {
            var result = await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<User> Update(User user)
        {
            var result = await context.Users
                .FirstOrDefaultAsync(e => e.Id == user.Id);

            if (result != null)
            {
                result.Name = user.Name;
                result.Surname = user.Surname;
                result.Email = user.Email;
                result.Phone = user.Phone;
                result.Weight = user.Weight;
                result.Age = user.Age;

                await context.SaveChangesAsync();

                return result;
            }

            return null;
        }
        public async void Delete(int userId)
        {
            var result = await context.Users
                .FirstOrDefaultAsync(e => e.Id == userId);
            if (result != null)
            {
                context.Users.Remove(result);
                await context.SaveChangesAsync();
            }
        }
    }
}
