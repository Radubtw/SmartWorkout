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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User").HasKey(u => u.Id);
            builder.Property(u => u.Name).IsRequired().HasMaxLength(40);
            builder.Property(u => u.Surname).IsRequired().HasMaxLength(40);
            builder.Property(u => u.Phone).HasMaxLength(15);
            builder.Property(u => u.Email).HasMaxLength(35);
            builder.Property(u => u.Weight).HasPrecision(2);
            builder.Property(u => u.Age);
        }
    }
}
