using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentSurvey.Models;

namespace StudentSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly IConfiguration _config;
        public readonly StudentDbContext _context;
        public SurveyController(IConfiguration config, StudentDbContext context)
        {
            _config = config;
            _context = context;
        }
        //Get All Student Whose fill the survey
        [AllowAnonymous]
        [HttpGet("GetAllStudent")]
        public async Task<IActionResult> GetAllStudent()
        {
            return Ok(_context.StudentSurveys.ToList());
        }
        //Post All student 

        [AllowAnonymous]
        [HttpPost("CreateStudentSurvey")]
        public async Task<IActionResult> CreateStudentSurvey(Survey student)
        {
            
            try
            {
                if (student == null)
                    return BadRequest();
                var survey = new Survey()
                {
                    StudentName = student.StudentName,
                    Email = student.Email,
                    Graduation_year = student.Graduation_year,
                    Organization_Name = student.Organization_Name,
                    Organization_Position = student.Organization_Position,
                    Question_1 = student.Question_1,
                    Question_2 = student.Question_2,
                    Question_3 = student.Question_3,
                    Question_4 = student.Question_4,
                    Question_5 = student.Question_5,
                    Question_6 = student.Question_6,
                    Question_7 = student.Question_7,    
                    Question_8 = student.Question_8,
                    Question_9 = student.Question_9,
                    Question_10 = student.Question_10,
                    Question_11 = student.Question_11,
                    Question_12 = student.Question_12,
                    Question_13 = student.Question_13,
                    Question_14 = student.Question_14,
                    Question_15 = student.Question_15,  
                    Question_16 = student.Question_16,  
                    Question_17 = student.Question_17,
                    Question_18 = student.Question_18,
                    Question_19 = student.Question_19,
                    Question_20 = student.Question_20,
                    Question_21 = student.Question_21,

                };
                await _context.StudentSurveys.AddAsync(survey);
                await _context.SaveChangesAsync();
                
                return Ok(survey);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [AllowAnonymous]
        [HttpPost("loginAdmin")]
        public async Task<IActionResult> Login(Login user)
        {
            var userExists = await _context.AdminLogin.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefaultAsync();
            if (userExists != null)
            {
                return Ok(new jwtService(_config).GenerateToken(                   
                    userExists.Email,
                    userExists.Id.ToString()

                    ));

            }

            return NotFound();

        }

        //Get All Employee Whose fill the survey
        [AllowAnonymous]
        [HttpGet("GetAllEmployee")]
        public async Task<IActionResult> GetAllEmployee()
        {
            return Ok(_context.EmployeeSurveys.ToList());
        }

        [AllowAnonymous]
        [HttpPost("CreateEmployeeSurvey")]

        public async Task<IActionResult> CreateEmployeeSurvey(EmployeeSurvey employee)
        {
            try
            {
                if(employee == null)
                    return BadRequest();
                var servey = new EmployeeSurvey()
                {
                    Question_1 = employee.Question_1,
                    Question_2 = employee.Question_2,
                    Question_3 = employee.Question_3,
                    Question_4 = employee.Question_4,
                    Question_5 = employee.Question_5,
                    Question_6 = employee.Question_6,
                    Question_7 = employee.Question_7,
                    Question_8 = employee.Question_8,
                    Question_9 = employee.Question_9,
                    Question_10 = employee.Question_10,
                    Question_11 = employee.Question_11,
                    Question_12 = employee.Question_12,
                    Question_13 = employee.Question_13,
                    Question_14 = employee.Question_14,
                    Question_15 = employee.Question_15,
                    Question_16 = employee.Question_16,
                    Question_17 = employee.Question_17,
                    Question_18 = employee.Question_18,
                    Question_19 = employee.Question_19,
                    Bussiness_Type = employee.Bussiness_Type,
                    Email = employee.Email,
                    NoOfGraduate = employee.NoOfGraduate,
                    Organization_Name = employee.Organization_Name
                };
                await _context.EmployeeSurveys.AddAsync(servey);
                await _context.SaveChangesAsync();
                return Ok(servey);

            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
