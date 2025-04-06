using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiceloNtuliOnlineCV.Models
{
    public class Project
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
        public string Link { get; set; }
    }
}
