﻿// <auto-generated />
using System;
using EFCoreAssignment1.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreAssignment1.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    [Migration("20250223162144_CreatTabelsByDataAnotaion")]
    partial class CreatTabelsByDataAnotaion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreAssignment1.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int>("Crs_Duration")
                        .HasColumnType("int")
                        .HasColumnName("Course_Duration");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Crs_Name");

                    b.Property<int>("Top_Id")
                        .HasColumnType("int")
                        .HasColumnName("Top_Id");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EFCoreAssignment1.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Dept_Desc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("Dept_Desc");

                    b.Property<string>("Dept_Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Dept_Location");

                    b.Property<int>("Dept_Manager")
                        .HasColumnType("int")
                        .HasColumnName("Department_Manger");

                    b.Property<DateTime>("Manager_hiredate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Dept_Name");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EFCoreAssignment1.Models.Instructor", b =>
                {
                    b.Property<int>("Ins_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ins_Id"));

                    b.Property<string>("Ins_Degree")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Ins_Degree");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Ins_Name");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("Ins_Salary");

                    b.HasKey("Ins_Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("EFCoreAssignment1.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Address");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Fname");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Lname");

                    b.Property<int>("Super")
                        .HasColumnType("int")
                        .HasColumnName("Super");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("EFCoreAssignment1.Models.Topic", b =>
                {
                    b.Property<int>("Top_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Top_Id"));

                    b.Property<string>("Top_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Top_Name");

                    b.HasKey("Top_Id");

                    b.ToTable("Topices");
                });
#pragma warning restore 612, 618
        }
    }
}
