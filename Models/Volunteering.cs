using System.Text.Json.Serialization;

namespace MudBlazorWebApp1.Models
{
    public class Volunteering
    {
        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        [JsonPropertyName("responsibilities")]
        public List<string> Responsibilities { get; set; }
    }
}
