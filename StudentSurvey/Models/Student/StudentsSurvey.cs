﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace StudentSurvey.Models.Student
{
    public class StudentsSurvey
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
        public string Question_19 { get; set; }
        public string Question_20 { get; set; }
        public string StudentName { get; set; }
        public string Registration_no { get; set; }
        public string CNIC_no { get; set; }
        public string Contact_no { get; set; }        
        public string Email { get; set; }       
        public string Employment_Status { get; set; }
        public string Department { get; set; }
        public string Organization_Name { get; set; }
        public string Organization_Position { get; set; }
        [Required]
        public string Comments { get; set; }
    }
}

