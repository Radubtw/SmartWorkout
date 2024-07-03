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
    public class Exercise_Log_Configuration : IEntityTypeConfiguration<Exercise_Log>
    {
        public void Configure(EntityTypeBuilder<Exercise_Log> builder)
        {
            builder.ToTable("Exercise_Log");
            builder.HasKey(el => new {el.Workout_Id, el.Exercise_Id});

            builder.HasOne(el => el.Exercise).WithMany(e => e.Exercise_Logs)
                .HasForeignKey(el => el.Exercise_Id).IsRequired()
                .HasConstraintName("FK_Exercise_Exercise_Log");
            builder.HasOne(el => el.Workout).WithMany(w => w.Exercise_Logs)
                .HasForeignKey(el => el.Workout_Id).IsRequired()
                .HasConstraintName("FK_Workout_Exercise_Log");

            builder.Property(el => el.Weight).HasPrecision(2);
            builder.Property(el => el.Sets);
            builder.Property(el => el.Reps);
            builder.Property(el => el.Duration);
            builder.Property(el => el.Distance);
        }
    }
}
