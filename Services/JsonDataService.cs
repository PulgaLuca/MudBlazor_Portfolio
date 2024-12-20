using MudBlazorWebApp1.Models;
using System.Text.Json;
using MudBlazorWebApp1.Commons;
using System.Xml.Linq;

namespace MudBlazorWebApp1.Services
{
    public class JsonDataService : IDataService
    {
        private readonly IWebHostEnvironment _environment;

        /// <summary>
        /// Initializes the JsonDataService with the provided IWebHostEnvironment.
        /// </summary>
        /// <param name="environment">The IWebHostEnvironment instance used to access application root paths.</param>
        public JsonDataService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        /// <summary>
        /// Converts a relative file path into an absolute file path based on the root path of the application.
        /// </summary>
        /// <param name="relativePath">The relative file path that needs to be converted to an absolute path.</param>
        /// <returns>Returns the absolute file path based on the root content path of the application.</returns>
        private string GetAbsolutePath(string relativePath)
        {
            return Path.Combine(_environment.ContentRootPath, relativePath.TrimStart('/'));
        }

        /// <summary>
        /// Asynchronously loads a JSON file and deserializes it into an object of type T.
        /// </summary>
        /// <typeparam name="T">The type of object into which the JSON should be deserialized.</typeparam>
        /// <param name="relativePath">The relative path of the JSON file to be loaded.</param>
        /// <returns>Returns an object of type T that represents the deserialized JSON data.</returns>
        private async Task<T> LoadJsonAsync<T>(string relativePath)
        {
            var path = GetAbsolutePath(relativePath);
            using var stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }

        /// <summary>
        /// Loads the CV data from the specified JSON file path and deserializes it into a CvData object.
        /// </summary>
        /// <param name="jsonFilePath">The path to the JSON file containing CV data.</param>
        /// <returns>Returns a CvData object containing the deserialized CV data.</returns>
        public async Task<CvData> LoadCVDataAsync(string jsonFilePath)
        {
            using var stream = new FileStream(jsonFilePath, FileMode.Open, FileAccess.Read);
            return await JsonSerializer.DeserializeAsync<CvData>(stream);
        }

        /// <summary>
        /// Asynchronously retrieves the work experience data from the JSON file and returns it as a list of WorkExperience objects.
        /// </summary>
        /// <returns>Returns an IEnumerable of WorkExperience representing the work experiences from the CV data.</returns>
        public async Task<IEnumerable<WorkExperience>> GetExperiencesAsync()
        {
            var data = await LoadJsonAsync<CvData>(AppConstants.JsonPath);
            return data.WorkExperience;
        }

        /// <summary>
        /// Asynchronously retrieves the education data from the JSON file and returns it as a list of Study objects.
        /// </summary>
        /// <returns>Returns an IEnumerable of Study representing the education data from the CV.</returns>
        public async Task<IEnumerable<Study>> GetStudiesAsync()
        {
            var data = await LoadJsonAsync<CvData>(AppConstants.JsonPath);
            return data.Education;
        }

        /// <summary>
        /// Asynchronously retrieves the project data from the JSON file and returns it as a list of Project objects.
        /// </summary>
        /// <returns>Returns an IEnumerable of Project representing the projects from the CV data.</returns>
        public async Task<IEnumerable<Project>> GetProjectsAsync()
        {
            var data = await LoadJsonAsync<CvData>(AppConstants.JsonPath);
            return data.Projects;
        }

        /// <summary>
        /// Asynchronously retrieves the award data from the JSON file and returns it as a list of Award objects.
        /// </summary>
        /// <returns>Returns an IEnumerable of Award representing the awards from the CV data.</returns>
        public async Task<IEnumerable<Award>> GetAwardsAsync()
        {
            var data = await LoadJsonAsync<CvData>(AppConstants.JsonPath);
            return data.Awards;
        }

        /// <summary>
        /// Asynchronously retrieves the volunteering data from the JSON file and returns it as a list of Volunteering objects.
        /// </summary>
        /// <returns>Returns an IEnumerable of Volunteering representing the volunteering activities from the CV data.</returns>
        public async Task<IEnumerable<Volunteering>> GetVolunteeringAsync()
        {
            var data = await LoadJsonAsync<CvData>(AppConstants.JsonPath);
            return data.Volunteering;
        }

    }
}
