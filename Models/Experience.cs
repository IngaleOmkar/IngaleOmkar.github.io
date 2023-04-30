using System;
namespace PersonlWebsite.Models
{
	public class Experience
	{
		public string? Name { get; set; }
		public string? Duration { get; set; }
		public string? Description { get; set; }
		public List<Skill>? SkillsGained { get; set; }
		public string? Position { get; set; }

		public Experience()
		{
		}
	}
}

