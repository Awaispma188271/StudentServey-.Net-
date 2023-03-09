using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentSurvey.Models;

namespace StudentSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentChartController : ControllerBase
    {
        private readonly IConfiguration _config;
        public readonly StudentDbContext _context;
        public StudentChartController(IConfiguration config, StudentDbContext context)
        {
            _config = config;
            _context = context;
        }

        [HttpGet("GetchartQ1/{id:int}")]
        public ActionResult GetDataQ1([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_1 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_1 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_1 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_1 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_1 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ2/{id:int}")]
        public ActionResult GetDataQ2([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_2 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_2 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_2 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_2 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_2 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ3/{id:int}")]
        public ActionResult GetDataQ3([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_3 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_3 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_3 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_3 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_3 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ4/{id:int}")]
        public ActionResult GetDataQ4([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_4 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_4 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_4 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_4 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_4 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ5/{id:int}")]
        public ActionResult GetDataQ5([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_5 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_5 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_5 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_5 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_5 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ6/{id:int}")]
        public ActionResult GetDataQ6([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_6 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_6 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_6 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_6 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_6 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ7/{id:int}")]
        public ActionResult GetDataQ7([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_7 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_7 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_7 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_7 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_7 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ8/{id:int}")]
        public ActionResult GetDataQ8([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_8 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_8 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_8 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_8 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_8 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ9/{id:int}")]
        public ActionResult GetDataQ9([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_9 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_9 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_9 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_9 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_9 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ10/{id:int}")]
        public ActionResult GetDataQ10([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_10 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_10 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_10 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_10 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_10 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ11/{id:int}")]
        public ActionResult GetDataQ11([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_11 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_11 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_11 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_11 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_11 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ12/{id:int}")]
        public ActionResult GetDataQ12([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_12 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_12 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_12 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_12 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_12 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ13/{id:int}")]
        public ActionResult GetDataQ13([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_13 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_13 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_13 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_13 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_13 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ14/{id:int}")]
        public ActionResult GetDataQ14([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_14 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_14 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_14 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_14 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_14 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ15/{id:int}")]
        public ActionResult GetDataQ15([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_15 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_15 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_15 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_15 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_15 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ16/{id:int}")]
        public ActionResult GetDataQ16([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_16 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_16 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_16 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_16 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_16 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ17/{id:int}")]
        public ActionResult GetDataQ17([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_17 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_17 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_17 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_17 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_17 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ18/{id:int}")]
        public ActionResult GetDataQ18([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_18 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_18 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_18 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_18 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_18 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ19/{id:int}")]
        public ActionResult GetDataQ19([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_19 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_19 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_19 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_19 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_19 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
        [HttpGet("GetchartQ20/{id:int}")]
        public ActionResult GetDataQ20([FromRoute] int id)
        {
            var adminLogin = _context.AdminLogin.Find(id);
            if (adminLogin == null)
                return NotFound();

            int Excellent = _context.StudentSurveys.Where(x => x.Question_20 == "Excellent" && x.Department == adminLogin.Department).Count();
            int Good = _context.StudentSurveys.Where(x => x.Question_20 == "Good" && x.Department == adminLogin.Department).Count();
            int Very_Good = _context.StudentSurveys.Where(x => x.Question_20 == "Very Good" && x.Department == adminLogin.Department).Count();
            int Fair = _context.StudentSurveys.Where(x => x.Question_20 == "Fair" && x.Department == adminLogin.Department).Count();
            int Poor = _context.StudentSurveys.Where(x => x.Question_20 == "Poor" && x.Department == adminLogin.Department).Count();

            Ratio obj = new Ratio();
            obj.Excellent = Excellent;
            obj.Good = Good;
            obj.Very_Good = Very_Good;
            obj.Fair = Fair;
            obj.Poor = Poor;
            return Ok(obj);

        }
       
       
        public class Ratio
        {
            public int Excellent { get; set; }
            public int Good { get; set; }
            public int Very_Good { get; set; }
            public int Fair { get; set; }
            public int Poor { get; set; }

        }
    }
}