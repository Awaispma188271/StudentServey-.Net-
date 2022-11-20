using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;

namespace StudentSurvey.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Survey> StudentSurveys { get; set; }
        public DbSet<EmployeeSurvey> EmployeeSurveys { get; set; }
        public DbSet<Login> AdminLogin { get; set; }

    }
}

