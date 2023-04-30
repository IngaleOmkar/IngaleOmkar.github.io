using System;
using PersonlWebsite.Models;

namespace PersonlWebsite.ViewModels
{
	public class ExperienceViewModel
	{
		public List<Experience> Experiences { get; set; } = new();

		public ExperienceViewModel()
		{
            PopulateExperiences();
		}

		public void PopulateExperiences()
		{
			Experiences.Add(new Experience()
			{
				Name = "AEM Singapore Pte Ltd",
				Position = "Software Engineering Intern",
				Description = "During my 20-week software engineering internship, I gained valuable experience in a range of technologies and tools. I focused on Windows development using WPF and Visual Studio, as well as programming in C# and unit testing using the Unit framework.\n\nOne of my key accomplishments during the internship was the development of a standalone compliance checking application. This involved creating a user-friendly interface that allowed users to input data and receive feedback on whether the system they were using had all the necessary apps and also that they didn't have any apps that were not in the list of approved apps. I also worked on ensuring the application was efficient, scalable and had a clean code base.\n\nIn addition to the above, I was also introduced to Blazor and MudBlazor, which are powerful tools for building interactive web applications. Throughout my internship, I had the opportunity to work with experienced developers who provided guidance and mentorship, allowing me to build my skills and confidence in software development.\n\nOverall, my internship provided me with a valuable foundation in software engineering, equipping me with the technical knowledge and practical experience I need to succeed in the field.",
				Duration = "Jan 2023 - June 2023",
				SkillsGained = new List<Skill>()
				{
					new Skill()
					{
						Name = "WPF"
					},
                    new Skill()
                    {
                        Name = "Unit Testing"
                    },
                    new Skill()
                    {
                        Name = "NUnit Framework"
                    },
                    new Skill()
                    {
                        Name = "Prism Library"
                    },
                    new Skill()
                    {
                        Name = "MVVM Architecture"
                    },
                    new Skill()
                    {
                        Name = "Blazor"
                    },
                    new Skill()
                    {
                        Name = "MudBlazor"
                    },
                    new Skill()
                    {
                        Name = "C#"
                    },
                    new Skill()
                    {
                        Name = "Visual Studio"
                    },
                    new Skill()
                    {
                        Name = "Client-Server Architecture"
                    },
                }
			});
		}
	}
}

