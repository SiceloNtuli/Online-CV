using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiceloNtuliOnlineCV.Models
{
    public class Education
    {
        [Required]
        public string Institution { get; set; }
        public string Degree { get; set; }
        public string FieldOfStudy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
