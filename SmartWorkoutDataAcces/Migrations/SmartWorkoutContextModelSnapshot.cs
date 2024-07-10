﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartWorkoutDataAccess;

#nullable disable

namespace SmartWorkoutDataAccess.Migrations
{
    [DbContext(typeof(SmartWorkoutContext))]
    partial class SmartWorkoutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Exercise", (string)null);
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.Exercise_Log", b =>
                {
                    b.Property<int>("Workout_Id")
                        .HasColumnType("int");

                    b.Property<int>("Exercise_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Distance")
                        .HasColumnType("int");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("Reps")
                        .HasColumnType("int");

                    b.Property<int?>("Sets")
                        .HasColumnType("int");

                    b.Property<double?>("Weight")
                        .HasPrecision(2)
                        .HasColumnType("float(2)");

                    b.HasKey("Workout_Id", "Exercise_Id");

                    b.HasIndex("Exercise_Id");

                    b.ToTable("Exercise_Log", (string)null);
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("Trainer_Id")
                        .HasColumnType("int");

                    b.Property<double?>("Weight")
                        .HasPrecision(2)
                        .HasColumnType("float(2)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Workout", (string)null);
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.Exercise_Log", b =>
                {
                    b.HasOne("SmartWorkoutDataAccess.Entities.Exercise", "Exercise")
                        .WithMany("Exercise_Logs")
                        .HasForeignKey("Exercise_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Exercise_Exercise_Log");

                    b.HasOne("SmartWorkoutDataAccess.Entities.Workout", "Workout")
                        .WithMany("Exercise_Logs")
                        .HasForeignKey("Workout_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Workout_Exercise_Log");

                    b.Navigation("Exercise");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.User", b =>
                {
                    b.HasOne("SmartWorkoutDataAccess.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.Workout", b =>
                {
                    b.HasOne("SmartWorkoutDataAccess.Entities.User", "User")
                        .WithMany("Workouts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Workout_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.Exercise", b =>
                {
                    b.Navigation("Exercise_Logs");
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.User", b =>
                {
                    b.Navigation("Workouts");
                });

            modelBuilder.Entity("SmartWorkoutDataAccess.Entities.Workout", b =>
                {
                    b.Navigation("Exercise_Logs");
                });
#pragma warning restore 612, 618
        }
    }
}
