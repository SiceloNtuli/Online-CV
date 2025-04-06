using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiceloNtuliOnlineCV.Models
{
    public class CVModel
    {
        
        public PersonalInfo PersonalInfo { get; set; }
        public string ProfessionalSummary { get; set; }
        public List<Experience> WorkExperience { get; set; }
        public List<Education> Education { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Project> Projects { get; set; }
    }

    public class PersonalInfo
    {
        [Required]
        public string FullName { get; set; } = "Sicelo Ntuli";
        public string ProfessionalTitle { get; set; } = "Junior Data Analyst";
        [EmailAddress]
        public string Email { get; set; } = "celontuli@gmail.com";
        public string Phone { get; set; } = "+27 (68) 621-2429";
        public string Location { get; set; } = "Johannesburg, South Afica";
        [Url]
        public string LinkedIn { get; set; } = "https://www.linkedin.com/in/sicelo-ntuli-954b93278/";
        [Url]
       
        public string GitHub { get; set; } = "https://github.com/SiceloNtuli?tab=overview&from=2025-04-01&to=2025-04-06";
    }
}
