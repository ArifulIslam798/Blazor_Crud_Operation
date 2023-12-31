﻿// <auto-generated />
using System;
using BlazorApp_Final_1270809.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp_Final_1270809.Server.Migrations
{
    [DbContext(typeof(CourseDbContext))]
    partial class CourseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp_Final_1270809.Shared.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"));

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("BatchName")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("CourseDesc")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("CourseDuration")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("BlazorApp_Final_1270809.Shared.Models.Exam", b =>
                {
                    b.Property<int>("ExamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExamID"));

                    b.Property<decimal>("ExamFee")
                        .HasColumnType("money");

                    b.Property<string>("ExamName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ExamID");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("BlazorApp_Final_1270809.Shared.Models.ExamResult", b =>
                {
                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<int>("TraineeID")
                        .HasColumnType("int");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.HasKey("ExamID", "TraineeID");

                    b.HasIndex("TraineeID");

                    b.ToTable("ExamResults");
                });

            modelBuilder.Entity("BlazorApp_Final_1270809.Shared.Models.Trainee", b =>
                {
                    b.Property<int>("TraineeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TraineeID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsRunning")
                        .HasColumnType("bit");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("TraineeAddress")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("TraineeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TraineeID");

                    b.HasIndex("CourseID");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("BlazorApp_Final_1270809.Shared.Models.ExamResult", b =>
                {
                    b.HasOne("BlazorApp_Final_1270809.Shared.Models.Exam", "Exam")
                        .WithMany("ExamResults")
                        .HasForeignKey("ExamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorApp_Final_1270809.Shared.Models.Trainee", "Trainee")
                        .WithMany("ExamResults")
                        .HasForeignKey("TraineeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("BlazorApp_Final_1270809.Shared.Models.Trainee", b =>
                {
                    b.HasOne("BlazorApp_Final_1270809.Shared.Models.Course", "Course")
                        .WithMany("Trainees")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("BlazorApp_Final_1270809.Shared.Models.Course", b =>
                {
                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("BlazorApp_Final_1270809.Shared.Models.Exam", b =>
                {
                    b.Navigation("ExamResults");
                });

            modelBuilder.Entity("BlazorApp_Final_1270809.Shared.Models.Trainee", b =>
                {
                    b.Navigation("ExamResults");
                });
#pragma warning restore 612, 618
        }
    }
}
