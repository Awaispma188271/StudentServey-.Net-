﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSurvey.Models;

#nullable disable

namespace StudentSurvey.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    [Migration("20230104113155_changeField")]
    partial class changeField
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentSurvey.Models.Authentication.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdminLogin");
                });

            modelBuilder.Entity("StudentSurvey.Models.Employee.EmployerSurvey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contact_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation_Employer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Designation_Evaluator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EvaluatorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job_Level")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_10")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_11")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_12")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_13")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_14")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_15")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_16")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_17")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_18")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_19")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_8")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_9")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registration_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployerSurveys");
                });

            modelBuilder.Entity("StudentSurvey.Models.Student.StudentsSurvey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNIC_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employment_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization_Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_10")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_11")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_12")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_13")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_14")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_15")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_16")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_17")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_18")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_19")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_20")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_21")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_8")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question_9")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Registration_no")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentSurveys");
                });
#pragma warning restore 612, 618
        }
    }
}
