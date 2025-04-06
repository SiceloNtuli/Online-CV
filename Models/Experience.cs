using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiceloNtuliOnlineCV.Models
{
    public class Experience
    {
        [Required]
        public string Company { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool Current { get; set; }
    }
}
