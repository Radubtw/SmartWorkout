using SmartWorkoutDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Repositories
{
    public class ExerciseRepository : IExerciseRepository
    {
        private SmartWorkoutContext context;
        public ExerciseRepository()
        {
            context = new SmartWorkoutContext();
        }
        public async void Save()
        {
            context.SaveChanges();
        }
        public async Task<IEnumerable<Exercise>> GetAll()
        {
            return await context.Exercises.ToArrayAsync();
        }
        public async Task<Exercise> GetById(int id)
        {
            return await context.Exercises.FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<Exercise> GetExerciseByName(string name)
        {
            return await context.Exercises.FirstOrDefaultAsync(e => string.Equals(e.Name, name));
        }
        public async Task<Exercise> Add(Exercise exercise)
        {
            var result = await context.Exercises.AddAsync(exercise);
            await context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Exercise> Update(Exercise exercise)
        {
            var result = await context.Exercises
                .FirstOrDefaultAsync(e => e.Id == exercise.Id);

            if (result != null)
            {
                result.Name = exercise.Name;

                await context.SaveChangesAsync();

                return result;
            }

            return null;
        }
        public async void Delete(int exerciseId)
        {
            var result = await context.Exercises
                .FirstOrDefaultAsync(e => e.Id == exerciseId);
            if (result != null)
            {
                context.Exercises.Remove(result);
                await context.SaveChangesAsync();
            }
        }
    }
}
