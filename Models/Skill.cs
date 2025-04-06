using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiceloNtuliOnlineCV.Models
{
    public class Skill
    {
        [Required]
        public string Name { get; set; }
        public int Proficiency { get; set; } // 1-5
        public string Category { get; set; }
    }
}
