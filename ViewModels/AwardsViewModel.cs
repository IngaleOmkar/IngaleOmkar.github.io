using System;
using PersonlWebsite.Models;

namespace PersonlWebsite.ViewModels
{
	public class AwardsViewModel
	{
		public List<Award> Awards { get; set; } = new();

		public AwardsViewModel()
		{
            PopulateAwards();
		}

		public void PopulateAwards()
		{
			Awards.Add(new Award()
			{
				Name = "NTU President Research Scholar",
				Description = "Awarded as part of my work in the URECA (Undergraduate Research on CAmpus) program."
			});
            Awards.Add(new Award()
            {
                Name = "Accepted into the Accelerated Bachelor's Programme, NTU",
                Description = "I was invited to join the ABP based on my CGPA. Being a part of this programme will allow me to graduate a semester ahead of time."
            });
            Awards.Add(new Award()
            {
                Name = "Dean's List, School of Arts and Sciences, Rutgers University",
                Description = "Included on the Dean's List for Fall 2019 (GPA: 3.8/4.0) Spring 2020 (GPA of 3.86/4.0)"
            });
            Awards.Add(new Award()
            {
                Name = "Invited to join the Honor's Program, Rutgers University",
                Description = "Based on my freshman year performance, I was invited to enroll in the School of Arts and Sciences Honors Program."
            });
            Awards.Add(new Award()
            {
                Name = "School of Arts and Sciences Excellence Award, Rutgers University",
                Description = "Awarded to students with a GPA of more than 3.7, I was invited to apply for this award based on my freshamn year performance. The award entailed a price of US$1000."
            });
            Awards.Add(new Award()
            {
                Name = "IBDP Subject profeciency",
                Description = "Awarded for having a perfect score in:\n1.Business Management SL \n2.TOK and EE"
            });
            Awards.Add(new Award()
            {
                Name = "Governor's Gold Medal",
                Description = "Awarded by the Governor of Hiranandani Foundation School for my grade 10 ICSE performance (94.83%)."
            });

        }
	}
}

