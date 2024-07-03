using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartWorkoutDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWorkoutDataAccess.Configurations
{
    public class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder.ToTable("Workout").HasKey(w => w.Id);

            builder.HasOne(w => w.User).WithMany(u => u.Workouts).HasForeignKey(w => w.UserId)
                .HasConstraintName("FK_Workout_User");

            builder.Property(w => w.Date).IsRequired();
            builder.Property(w => w.Duration);
        }
    }
}
