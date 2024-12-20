using System.Text.Json.Serialization;

namespace MudBlazorWebApp1.Models
{
    public class Award
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("issuer")]
        public string Issuer { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
