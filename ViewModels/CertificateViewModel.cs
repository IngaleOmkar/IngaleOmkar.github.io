using System;
using PersonlWebsite.Models;

namespace PersonlWebsite.ViewModels
{
	public class CertificateViewModel
	{
        public List<Certificate> Certificates { get; set; } = new();

        public CertificateViewModel()
		{
            PopulateCertificates();
		}

		public void PopulateCertificates()
		{
			Certificates.Add(new Certificate
			{
				Name = "JPMorgan Chase & Co. Virtual Experience Program Participant [2021]-[5 Hours]",
				Description = "Participated in the open access JPMorgan Chase & Co. Virtual Experience Program with Forage\nTasks completed include:\no Interface with stock price data feed\no Use JPMorgan Chase frameworks and tools\no Display data visually for traders",
                PDFName = "JPM.pdf"
			});
            Certificates.Add(new Certificate
            {
                Name = "Global Academic Internship Program offered by National Univeristy of Singapore and Hewlett Packard Enterprises",
                Description = "o Program on deep learning offered by National University of Singapore and HPE\no Graded A+ by faculty of NUS",
                PDFName = "NUS.pdf/HPE.pdf"
            });
            Certificates.Add(new Certificate
            {
                Name = "Smart Contracts",
                WebLink = "https://coursera.org/share/c49eae1bfb9b8fda0037a4ffecdff57f"
            });
            Certificates.Add(new Certificate
            {
                Name = "Blockchain Basics",
                WebLink = "https://www.linkedin.com/learning/certificates/08584d64850c4a1a831dd300d780a52f1d4c697ade8c254920f9cf1822875e92",
            });
            Certificates.Add(new Certificate
            {
                Name = "Blockchain: Beyond the Basics",
                WebLink = "https://www.linkedin.com/learning/certificates/a632684766e5c525f871632026aa0db7f8edef3e6110e52075cf61b7593be987",
            });
            Certificates.Add(new Certificate
            {
                Name = "Blockchain: Learning Solidity",
                WebLink = "https://www.linkedin.com/learning/certificates/5c04befbc58ada14bad118a96c4f2361097d18ec181e23a3f0901a4bdc4052d1",
            });
            Certificates.Add(new Certificate
            {
                Name = "Ethereum: Building Blockchain Decentralised Apps (DApps)",
                WebLink = "https://www.linkedin.com/learning/certificates/7721c33be3c843d1ffc83c59ef4713df18e32d3e6eccb2281f2663a855ef0faf",
            });
            Certificates.Add(new Certificate
            {
                Name = "Cryptocurrency Foundations",
                WebLink = "https://www.linkedin.com/learning/certificates/346bcb8b9e37a10ace844dd6a89a854226e5f18dbdb43b9c28defae47bad40ec",
            });
            Certificates.Add(new Certificate
            {
                Name = "Introduction to Web APIs",
                WebLink = "https://www.linkedin.com/learning/certificates/4803a659511893bea44601ab519d0844766df5f3458c68a32a3d4f09d23564d8"
            });
            Certificates.Add(new Certificate
            {
                Name = "Learning Rest APIs",
                WebLink = "https://www.linkedin.com/learning/certificates/b07583c9f20a843f977fabe39633bfbf4a780fc0c38cb2bcdc16d44a115a0974"
            });
            Certificates.Add(new Certificate
            {
                Name = "LinkedIn Skill Assessment Badge",
                Description = "Java Programming Language",
            });
            Certificates.Add(new Certificate
            {
                Name = "LinkedIn Skill Assessment Badge",
                Description = "Object-Oriented Programming",
            });
            Certificates.Add(new Certificate
            {
                Name = "LinkedIn Skill Assessment Badge",
                Description = "Python Programming Language",
            });
            Certificates.Add(new Certificate
            {
                Name = "HackerRank",
                Description = "Problem Solving",
                WebLink = "https://www.hackerrank.com/certificates/b2e9d778edca"
            });
            Certificates.Add(new Certificate
            {
                Name = "HackerRank",
                Description = "Java Basic",
                WebLink= "https://www.hackerrank.com/certificates/29b77b5188da"
            });
            Certificates.Add(new Certificate
            {
                Name = "HackerRank",
                Description = "Python Basic",
                WebLink= "https://www.hackerrank.com/certificates/375304c8adcf"
            });
        }
	}
}

