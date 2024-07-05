using SmartWorkoutDataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Repositories
{
    public class Exercise_Log_Repository : IExercise_Log_Repository
    {
        private SmartWorkoutContext context;
        public Exercise_Log_Repository()
        {
            context = new SmartWorkoutContext();
        }
        public async void Save()
        {
            await context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Exercise_Log>> GetAll()
        {
            return await context.Exercise_Logs.ToListAsync();
        }
        public async Task<Exercise_Log> GetById(int id)
        {
            return await context.Exercise_Logs.FirstOrDefaultAsync(e => e.Workout_Id == id);
        }
        public async Task<IEnumerable<Exercise_Log>> GetExerciseLogsWithExercisesByWorkoutId(int workoutId)
        {
            return await context.Exercise_Logs
                .Where(el => el.Workout_Id == workoutId)
                .Include(el => el.Exercise)
                .ToListAsync();
        }
        public async Task<Exercise_Log> Add(Exercise_Log exercise_Log)
        {
            var result = await context.Exercise_Logs.AddAsync(exercise_Log);
            await context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Exercise_Log> Update(Exercise_Log exercise_Log)
        {
            var result = await context.Exercise_Logs
                .FirstOrDefaultAsync(e => e.Workout_Id == exercise_Log.Workout_Id && e.Exercise_Id == exercise_Log.Exercise_Id);

            if (result != null)
            {
                result.Distance = exercise_Log.Distance;
                result.Exercise = exercise_Log.Exercise;
                result.Reps = exercise_Log.Reps;
                result.Weight = exercise_Log.Weight;
                result.Sets = exercise_Log.Sets;

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
        public async Task Delete(int workoutId, int exerciseId)
        {
            var exerciseLog = await context.Exercise_Logs
                .FirstOrDefaultAsync(el => el.Workout_Id == workoutId && el.Exercise_Id == exerciseId);

            if (exerciseLog != null)
            {
                context.Exercise_Logs.Remove(exerciseLog);
                await context.SaveChangesAsync();
            }
        }
        public async Task<Exercise_Log> GetExerciseLogByWorkoutAndExerciseId(int workoutId, int exerciseId)
        {
            return await context.Exercise_Logs.FirstOrDefaultAsync(el => el.Workout_Id == workoutId && el.Exercise_Id == exerciseId);

        }


    }
}
