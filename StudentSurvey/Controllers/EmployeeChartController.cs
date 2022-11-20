using Microsoft.AspNetCore.Mvc;
using StudentSurvey.Models;

namespace StudentSurvey.Controllers
{
    
        [Route("api/[controller]")]
        [ApiController]
        public class EmployeeChartController : ControllerBase
        {
            private readonly IConfiguration _config;
            public readonly StudentDbContext _context;
            public EmployeeChartController(IConfiguration config, StudentDbContext context)
            {
                _config = config;
                _context = context;
            }
            [HttpGet("GetchartQ1")]

            public ActionResult GetDataQ1()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_1 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_1 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_1 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_1 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_1 == "Poor").Count();
                //int female = context.HighCharts.Where(x => x.Gender == "Female").Count();
                //int other = context.HighCharts.Where(x => x.Gender == "Other").Count();
                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;
                return Ok(obj);

            }
            [HttpGet("GetchartQ2")]

            public ActionResult GetDataQ2()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_2 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_2 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_2 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_2 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_2 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;

                obj.Poor = Poor;
                return Ok(obj);
            }
            [HttpGet("GetchartQ3")]

            public ActionResult GetDataQ3()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_3 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_3 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_3 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_3 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_3 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }

            [HttpGet("GetchartQ4")]

            public ActionResult GetDataQ4()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_4 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_4 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_4 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_4 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_4 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ5")]

            public ActionResult GetDataQ5()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_5 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_5 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_5 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_5 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_5 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ6")]

            public ActionResult GetDataQ6()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_6 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_6 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_6 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_6 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_6 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }

            [HttpGet("GetchartQ7")]

            public ActionResult GetDataQ7()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_7 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_7 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_7 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_7 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_7 == "Poor").Count();
                //int female = context.HighCharts.Where(x => x.Gender == "Female").Count();
                //int other = context.HighCharts.Where(x => x.Gender == "Other").Count();
                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ8")]

            public ActionResult GetDataQ8()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_8 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_8 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_8 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_8 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_8 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ9")]

            public ActionResult GetDataQ9()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_9 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_9 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_9 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_9 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_9 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ10")]

            public ActionResult GetDataQ10()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_10 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_10 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_10 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_10 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_10 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ11")]

            public ActionResult GetDataQ11()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_11 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_11 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_11 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_11 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_11 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ12")]

            public ActionResult GetDataQ12()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_12 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_12 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_12 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_12 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_12 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ13")]

            public ActionResult GetDataQ13()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_13 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_13 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_13 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_13 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_13 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ14")]

            public ActionResult GetDataQ14()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_14 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_14 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_14 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_14 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_14 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ15")]

            public ActionResult GetDataQ15()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_15 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_15 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_15 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_15 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_15 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ16")]

            public ActionResult GetDataQ16()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_16 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_16 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_16 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_16 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_16 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ17")]

            public ActionResult GetDataQ17()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_17 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_17 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_17 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_17 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_17 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ18")]

            public ActionResult GetDataQ18()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_18 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_18 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_18 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_18 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_18 == "Poor").Count();

                Ratio obj = new Ratio();
                obj.Excellent = Excellent;
                obj.Good = Good;
                obj.Very_Good = Very_Good;
                obj.Fair = Fair;
                obj.Poor = Poor;

                return Ok(obj);
            }
            [HttpGet("GetchartQ19")]

            public ActionResult GetDataQ19()
            {
                int Excellent = _context.EmployeeSurveys.Where(x => x.Question_19 == "Excellent").Count();
                int Good = _context.EmployeeSurveys.Where(x => x.Question_19 == "Good").Count();
                int Very_Good = _context.EmployeeSurveys.Where(x => x.Question_19 == "Very Good").Count();
                int Fair = _context.EmployeeSurveys.Where(x => x.Question_19 == "Fair").Count();
                int Poor = _context.EmployeeSurveys.Where(x => x.Question_19 == "Poor").Count();

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
