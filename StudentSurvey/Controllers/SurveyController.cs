using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentSurvey.Models;
using StudentSurvey.Models.Authentication;
using StudentSurvey.Models.Employee;
using StudentSurvey.Models.Student;

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
        [HttpGet("GetAllStudent/{id:int}")]
       
        public async Task<IActionResult> GetAllStudent([FromRoute] int id)
        {
            try
            {
                var adminLogin = _context.AdminLogin.FirstOrDefault(p => p.Id == id);
                if (adminLogin == null)
                    return BadRequest();

                var studentSurveyDepartmentVice = _context.StudentSurveys.Where(p => p.Department == adminLogin.Department).ToList();
                return Ok(studentSurveyDepartmentVice);
            }
            catch (Exception)
            {

            }
            return BadRequest();
        }
       
        //Post All student 

        [AllowAnonymous]
        [HttpPost("CreateStudentSurvey")]
        public async Task<IActionResult> CreateStudentSurvey(StudentsSurvey student)
        {
            try
            {
                if (student == null)
                    return BadRequest();
               
                await _context.StudentSurveys.AddAsync(student);
                await _context.SaveChangesAsync();
                return Ok(student);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Delete
        [AllowAnonymous]
        [HttpDelete("deleteStudentEntity/{id}")]
        public async Task<IActionResult> deleteStudentEntity([FromRoute] int id)
        {
            try
            {
                var findId = _context.StudentSurveys.Find(id);
                if (findId == null)
                    return BadRequest();

                 _context.StudentSurveys.Remove(findId);
                await _context.SaveChangesAsync();
                return Ok();
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
            var userLogin = await _context.AdminLogin.Where(u => u.Email == user.Email && u.Password == user.Password).FirstOrDefaultAsync();
            if (userLogin != null)
            {
                return Ok(new jwtService(_config).GenerateToken(
                    userLogin.Email, 
                    userLogin.Id.ToString(),
                    userLogin.Department
                    ));
            }

            return NotFound();

        }

        //Get All Employee Whose fill the survey
        [AllowAnonymous]
        [HttpGet("GetAllEmployee/{id:int}")]
        public async Task<IActionResult> GetAllEmployee([FromRoute] int id )
        {
            var adminLogin = await _context.AdminLogin.FirstOrDefaultAsync(x => x.Id == id);
            if (adminLogin == null)
                return BadRequest();
            var EmployerSurveyDepartmentVice =_context.EmployerSurveys.Where(x =>x.Department == adminLogin.Department).ToList();
            return Ok(EmployerSurveyDepartmentVice);
        }
        //delete
        [AllowAnonymous]
        [HttpDelete("deleteEmployeeEntity/{id}")]
        public async Task<IActionResult> deleteEmployeeEntity([FromRoute] int id)
        {
            try
            {
                var findId = _context.EmployerSurveys.Find(id);
                if (findId == null)
                    return BadRequest();

                _context.EmployerSurveys.Remove(findId);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [AllowAnonymous]
        [HttpPost("CreateEmployeeSurvey")]

        public async Task<IActionResult> CreateEmployeeSurvey(EmployerSurvey employee)
        {
            try
            {
                if(employee == null)
                    return BadRequest();
                await _context.EmployerSurveys.AddAsync(employee);
                await _context.SaveChangesAsync();
                return Ok(employee);

            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
