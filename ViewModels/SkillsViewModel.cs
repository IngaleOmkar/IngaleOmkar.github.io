using System;
using PersonlWebsite.Models;

namespace PersonlWebsite.ViewModels
{
	public class SkillsViewModel
	{
		public List<Skill> Skills { get; set; } = new();

		public SkillsViewModel()
		{
			PopulateSkills();
		}

		public void PopulateSkills()
		{
            Skills.Add(new Skill()
            {
                Name = "WPF"
            });
            Skills.Add(new Skill()
            {
                Name = "MudBlazor"
            });
            Skills.Add(new Skill()
            {
                Name = "Blazor"
            });
            Skills.Add(new Skill()
            {
                Name = ".NET"
            });
            Skills.Add(new Skill()
            {
                Name = "MVVM Architecture"
            });
            Skills.Add(new Skill()
            {
                Name = "Entity FrameWork Core"
            });
            Skills.Add(new Skill()
            {
                Name = "Visual Studio"
            });
            Skills.Add(new Skill()
            {
                Name = "C#"
            });
            Skills.Add(new Skill()
            {
                Name = "Unit Testing"
            });
            Skills.Add(new Skill()
            {
                Name = "NUnit Framework"
            });
            Skills.Add(new Skill()
            {
                Name = "Prism Library"
            });
            Skills.Add(new Skill()
			{
				Name= "Java"
            });
            Skills.Add(new Skill()
            {
                Name = "Python"
            });
            Skills.Add(new Skill()
            {
                Name = "SQL"
            });
            Skills.Add(new Skill()
            {
                Name = "Microsoft Office"
            });
            Skills.Add(new Skill()
            {
                Name = "C/C++"
            });
            Skills.Add(new Skill()
            {
                Name = "CSS"
            });
            Skills.Add(new Skill()
            {
                Name = "HTML"
            });
        }
	}
}

