using MudBlazorWebApp1.Models;

namespace MudBlazorWebApp1.Services
{
    public class DataService : IDataService
    {
        /// <summary>
        /// Asynchronously retrieves a list of work experiences.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The result contains a list of <see cref="WorkExperience"/>.</returns>
        public async Task<IEnumerable<WorkExperience>> GetExperiencesAsync()
        {
            return await Task.FromResult(new List<WorkExperience>
            {
                new WorkExperience
                {
                    Role = "Software Engineer Consultant",
                    Company = "Akkodis",
                    StartDate = "07/2023",
                    EndDate = "12/2024",
                    Responsibilities = new List<string>
                    {
                        "Improved database structure and CRUD operations",
                        "Implemented automated test cases using TDD principles"
                    }
                }
            });
        }

        /// <summary>
        /// Asynchronously retrieves a list of education details.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The result contains a list of <see cref="Study"/>.</returns>
        public async Task<IEnumerable<Study>> GetStudiesAsync()
        {
            return await Task.FromResult(new List<Study>
            {
                new Study
                {
                    Degree = "BS in Computer Science and Engineering"
                }
            });
        }

        /// <summary>
        /// Asynchronously retrieves a list of projects.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The result contains a list of <see cref="Project"/>.</returns>
        public async Task<IEnumerable<Project>> GetProjectsAsync()
        {
            return await Task.FromResult(new List<Project>
            {
                new Project
                {
                    Title = "S.A.F.E. Platform",
                    Description = "AI-driven forecasting for natural disaster risk."
                }
            });
        }

        /// <summary>
        /// Asynchronously retrieves a list of awards.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The result is null since no awards data is provided in this implementation.</returns>
        public Task<IEnumerable<Award>> GetAwardsAsync()
        {
            return null;
        }

        /// <summary>
        /// Asynchronously retrieves a list of volunteering experiences.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The result is null since no volunteering data is provided in this implementation.</returns>
        public Task<IEnumerable<Volunteering>> GetVolunteeringAsync()
        {
            return null;
        }
    }
}
