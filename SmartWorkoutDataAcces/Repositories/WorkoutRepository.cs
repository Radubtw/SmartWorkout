using SmartWorkoutDataAccess.Entities;
using SmartWorkoutDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Frozen;
using System.Collections;
using SmartWorkout.Components.Pages;

namespace SmartWorkoutDataAccess.Repositories
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private SmartWorkoutContext context;
        public WorkoutRepository()
        {
            context = new SmartWorkoutContext();
        }
        public void IDisposable()
        {
            return;
        }
        public void Save()
        {
            context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Workout>> GetAll()
        {
            return await context.Workouts.ToListAsync();
        }
        /*public async Task<IEnumerable<Workout>> GetAllExerciseLogs(Workout workout)
        {
            return  await workout.Exercise_Logs.;
        }*/

        public async Task<Workout> GetById(int id)
        {
            return await context.Workouts.FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<IEnumerable<Workout>> GetWorkoutsByUserId(int userId)
        {
            return await context.Workouts.Where(w => w.UserId == userId).ToListAsync();

        }
        public async Task<Workout> Add(Workout workout)
        {
            var result = await context.Workouts.AddAsync(workout);
            await context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Workout> Update(Workout workout)
        {
            var result = await context.Workouts
                .FirstOrDefaultAsync(e => e.Id == workout.Id);

            if (result != null)
            {
                result.Duration = workout.Duration;
                result.Date = workout.Date;

                await context.SaveChangesAsync();

                return result;
            }

            return null;
        }
        public async void Delete(int userId)
        {
            var result = await context.Workouts
                .FirstOrDefaultAsync(e => e.Id == userId);
            if (result != null)
            {
                context.Workouts.Remove(result);
                await context.SaveChangesAsync();
            }
        }
    }
}

