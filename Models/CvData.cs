using System.Text.Json.Serialization;

namespace MudBlazorWebApp1.Models
{
    public class CvData
    {
        [JsonPropertyName("work_experience")]
        public List<WorkExperience> WorkExperience { get; set; }

        [JsonPropertyName("education")]
        public List<Study> Education { get; set; }

        [JsonPropertyName("awards")]
        public List<Award> Awards { get; set; }

        [JsonPropertyName("projects")]
        public List<Project> Projects { get; set; }

        [JsonPropertyName("volunteeting")]
        public List<Volunteering> Volunteering { get; set; }
    }
}
