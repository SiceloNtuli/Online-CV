using Microsoft.AspNetCore.Mvc;
using SiceloNtuliOnlineCV.Models;

namespace SiceloNtuliOnlineCV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var cvData = new CVModel
            {
                PersonalInfo = new PersonalInfo(),
                ProfessionalSummary = "A dedicated and ambitious third-year Computer Science student with a strong passion for Software Development, Data analytics and IT Support. Adept at problem-solviing, troubleshooting technical issues and developing software solutios. Eager to apply theoretical knowledge in a practical environment and contribute to innovatiove projects." ,
                WorkExperience = new List<Experience>
                {
                    new Experience
                    {
                        Company = "IIE Varsity College",
                        Position = "Student Mentor",
                        Description = "The GRIT3sixT mentorship programme is a semester-long student engagement programme tailored for first year undergrad students. The programme aims to facilitate the successful integration of first year students as they navigate their transition into tertiary studies. The name of the programme is GRIT3sixT, derived from – growth, resilience, inclusion, transformation – encapsulating the qualities that the programme aims to develop in students.  " ,
                        StartDate = new DateTime(2020, 1, 1),
                        Current = true
                    }
                    
                },
                Education = new List<Education>
                {
                    new Education
                    {
                        Institution = "IIE Varsity College",
                        Degree = "Bachelor of Information and Computer Science",
                        FieldOfStudy = "Application Development",
                        StartDate = new DateTime(2023, 3, 1),
                        EndDate = new DateTime(2026, 3, 31)
                    }
                },
                Skills = new List<Skill>
                {
                    new Skill { Name = "C#", Proficiency = 5, Category = "Programming Languages" },
                    new Skill { Name = "ASP.NET MVC", Proficiency = 5, Category = "Frameworks" },
                    new Skill { Name = "Java", Proficiency = 4, Category = "Programming Languages" },
                    new Skill { Name = "HTML/CSS", Proficiency = 4, Category = "Web Technologies" },
                    new Skill { Name = "SQL", Proficiency = 4, Category = "Databases" },
                    new Skill { Name = "Git", Proficiency = 4, Category = "Tools" },
                    new Skill { Name = "Azure", Proficiency = 3, Category = "Cloud" }
                },
                Projects = new List<Project>
                {
                    new Project
                    {
                        Name = "Recipe App",
                        Description = "This console application allows you to manage recipes, including entering new recipes, displaying existing ones, scaling them, and more.",
                        Technologies = new List<string> { "Visual Studio 2022", "Console App", "C#", "SQL Server" },
                        Link = "https://github.com/VCSTDN/prog6221-poe-SiceloNtuli.git"
                    },
                    new Project
                    {
                        Name = "E-Commerce Website",
                        Description = "Built an online store with Visual Studios MVC and MySql database integration for product and user management.",
                        Technologies = new List<string> { "ASP.NET MVC", "Visual Studio 2022", "Azure", "MySQL database" },
                        Link = "https://github.com/VCSTDN/cldv6211-poe-SiceloNtuli.git"
                    }
                }
            };

            return View(cvData);
        }
    }
}
