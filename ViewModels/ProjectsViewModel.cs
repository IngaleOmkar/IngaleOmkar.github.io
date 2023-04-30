using System;
using PersonlWebsite.Models;

namespace PersonlWebsite.ViewModels
{
	public class ProjectsViewModel
	{
		public List<Project> Projects { get; set; } = new();

		public ProjectsViewModel()
		{
			PopulateProjects();
		}

		public void PopulateProjects()
		{
			Projects.Add(new Project()
			{
				Name = "CZ2006: Software Engineering",
				Description = "Worked on the Space Racing feature on BeatStride, a racing/fitness app developed alongside a team for my Software Engineering course. The feature accessed the Google Places API to collect park locations."
            });
            Projects.Add(new Project()
            {
                Name = "CZ1115: Introduction to Data Science and Artificial Intelligence",
                Description = "Developed alongside a team for my Introduction to Data Science and Artificial Intelligence course. Used machine learning models such as Long Short Term Memory (LSTM) to predict bitcoin prices using previous bitcoin prices in addition to 5 global stock indices. The data was obtained via the Alpha Vantage Stock API (alpha_vantage) and Yahoo Finance (yfinance)"
            });
            Projects.Add(new Project()
            {
                Name = "Depression Detection using Neural Networks",
                Description = "Developed alongside team during Global Academic Internship Program offered by Corporate Gurukul with the help of NUS and HPE.\n\nScrapped reddit data using the PRAW API\n\nBuilt a LSTM neural network to classify text as Depressed or Not Depressed\n\nCreated a Flask application for the GUI\n\nCreated a docker container for deployment\n\nDeployed using Azure as a Web App"
            });
            Projects.Add(new Project()
            {
                Name = "CZ2002: Object Oriented Design and Programming",
                Description = "Created a Restaurant Management System alongside a team for the course project. \nThe system had a command line interface and was coded entirely in java using object oriented principles."
            });
        }
	}
}

