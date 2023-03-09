using System.ComponentModel.DataAnnotations;

namespace StudentSurvey.Models.Employee
{
    public class EmployerSurvey
    {

        [Key]
        public int Id { get; set; }
        public string Question_1 { get; set; }
        public string Question_2 { get; set; }
        public string Question_3 { get; set; }
        public string Question_4 { get; set; }
        public string Question_5 { get; set; }
        public string Question_6 { get; set; }
        public string Question_7 { get; set; }
        public string Question_8 { get; set; }
        public string Question_9 { get; set; }
        public string Question_10 { get; set; }
        public string Question_11 { get; set; }
        public string Question_12 { get; set; }
        public string Question_13 { get; set; }
        public string Question_14 { get; set; }
        public string Question_15 { get; set; }
        public string Question_16 { get; set; }
        public string Question_17 { get; set; }
        public string Question_18 { get; set; }

        //Evaluator information
        public string EvaluatorName { get; set; }
        public string Designation_Evaluator { get; set; }
        public string Organization_Name { get; set; }
        public string Contact_no { get; set; }
        public string Email { get; set; }
        //Graduate information
        public string EmployerName { get; set; }
        public string Designation_Employer { get; set; }
        public string Registration_no { get; set; }
        public string Job_Level { get; set; }
        public string Department { get; set; }
        public string Comments { get; set; }
    }
}

