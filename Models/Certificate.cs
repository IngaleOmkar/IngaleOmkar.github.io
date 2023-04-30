using System;

namespace PersonlWebsite.Models
{
	public class Certificate
	{
        public string? Name { get; set; }
        public string? Description { get; set; }
		public string? PDFName { get; set; }
        public string? WebLink { get; set; }

        public Certificate()
		{
		}
	}
}

