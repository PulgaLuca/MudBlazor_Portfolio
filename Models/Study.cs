using System.Text.Json.Serialization;

namespace MudBlazorWebApp1.Models
{
    public class Study
    {
        [JsonPropertyName("degree")]
        public string Degree { get; set; }

        [JsonPropertyName("institution")]
        public string Institution { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        [JsonPropertyName("details")]
        public List<string> Details { get; set; }
    }
}
