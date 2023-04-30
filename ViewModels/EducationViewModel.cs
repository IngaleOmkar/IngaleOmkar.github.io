using System;
using PersonlWebsite.Models;

namespace PersonlWebsite.ViewModels
{
	public class EducationViewModel
	{
		public List<EducationInstitution> educationInstitutions { get; set; } = new();

		public EducationViewModel() {
			PopulateListOfSchools();
		}

		public void PopulateListOfSchools()
		{
			educationInstitutions.Add(new EducationInstitution()
			{
                ImagePath = "/images/NTU.jpeg",
                Name = "Nanyang Technological University, Singapore",
				Location = "Singapore",
				Degree = "Bachelor of Engineering, Computer Science",
				Description = "CGPA: 4.2, NTU President Research Scholar",
				EndDate = new DateOnly(2024, 5, 1),
				StartDate = new DateOnly(2020, 8, 1),
			});
            educationInstitutions.Add(new EducationInstitution()
            {
                ImagePath = "/images/Rutgers.jpeg",
                Name = "Rutgers, The State University of New Jersey",
                Location = "New Jersey, USA",
                Degree = "Bachelor of Science, Computer Science",
                Description = "GPA: 3.83, Dean's list for all semesters attended",
                EndDate = new DateOnly(2020, 5, 1),
                StartDate = new DateOnly(2019, 8, 1),
            });
            educationInstitutions.Add(new EducationInstitution()
            {
                ImagePath = "/images/GIIS.jpeg",
                Name = "Global Indian International School, Singapore",
                Location = "Singapore",
                Degree = "International Baccalaureate Diploma Programme",
                Description = "IB Score: 39/45. Perfect Score in Business Administration and TOK + EE",
                EndDate = new DateOnly(2017, 9, 2),
                StartDate = new DateOnly(2019, 6, 1),
            });
        }
	}
}

