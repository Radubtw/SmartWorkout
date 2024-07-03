using Microsoft.EntityFrameworkCore;
using SmartWorkoutDataAccess.Configurations;
using SmartWorkoutDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess
{
    public class SmartWorkoutContext : DbContext
    {
        public SmartWorkoutContext() { }
        public SmartWorkoutContext(DbContextOptions<SmartWorkoutContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Exercise_Log> Exercise_Logs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString =
                    "Data Source=DESKTOP-QJRSB8H\\SQLEXPRESS;Initial Catalog=SmartWorkout;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new WorkoutConfiguration().Configure(modelBuilder.Entity<Workout>());
            new ExerciseConfiguration().Configure(modelBuilder.Entity<Exercise>());
            new Exercise_Log_Configuration().Configure(modelBuilder.Entity<Exercise_Log>());
        }
    }
}
