using System;

namespace PersonlWebsite.Models
{
	public class EducationInstitution
	{

		public string? ImagePath { get; set; }
		public string? Name { get; set; }
		public string? Description { get; set; }
		public DateOnly? StartDate { get; set; }
		public DateOnly? EndDate { get; set; }
		public string? Degree { get; set; }
		public string? Location { get; set; }

		public EducationInstitution() { }
	}
}