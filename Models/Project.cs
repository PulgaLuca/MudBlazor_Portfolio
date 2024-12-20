using System.Text.Json.Serialization;

namespace MudBlazorWebApp1.Models
{
    public class Project
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
