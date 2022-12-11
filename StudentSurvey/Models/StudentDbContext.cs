using Microsoft.EntityFrameworkCore;
using StudentSurvey.Models.Authentication;
using StudentSurvey.Models.Employee;
using StudentSurvey.Models.Student;
using System.Collections.Generic;
using System.Data;

namespace StudentSurvey.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        //Student Tables
        public DbSet<StudentsSurvey> StudentSurveys { get; set; }
        //Empplyee Tables
        public DbSet<EmployerSurvey> EmployerSurveys { get; set; }
        //Admin Tables
        public DbSet<Login> AdminLogin { get; set; }

    }
}

