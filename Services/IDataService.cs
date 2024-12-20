using MudBlazorWebApp1.Models;

namespace MudBlazorWebApp1.Services
{
    /// <summary>
    /// Defines the contract for a service that provides data for work experiences, education, projects, awards, and volunteering.
    /// </summary>
    public interface IDataService
    {
        /// <summary>
        /// Asynchronously retrieves a list of work experiences.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The result contains a list of <see cref="WorkExperience"/> objects.</returns>
        Task<IEnumerable<WorkExperience>> GetExperiencesAsync();

        /// <summary>
        /// Asynchronously retrieves a list of education details.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The result contains a list of <see cref="Study"/> objects.</returns>
        Task<IEnumerable<Study>> GetStudiesAsync();

        /// <summary>
        /// Asynchronously retrieves a list of projects.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The result contains a list of <see cref="Project"/> objects.</returns>
        Task<IEnumerable<Project>> GetProjectsAsync();

        /// <summary>
        /// Asynchronously retrieves a list of awards.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The result contains a list of <see cref="Award"/> objects, or <c>null</c> if no data is available.</returns>
        Task<IEnumerable<Award>> GetAwardsAsync();

        /// <summary>
        /// Asynchronously retrieves a list of volunteering experiences.
        /// </summary>
        /// <returns>A task representing the asynchronous operation. The result contains a list of <see cref="Volunteering"/> objects, or <c>null</c> if no data is available.</returns>
        Task<IEnumerable<Volunteering>> GetVolunteeringAsync();
    }
}
