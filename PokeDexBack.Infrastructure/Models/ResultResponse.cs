
using Newtonsoft.Json;

namespace PokeDexBack.Infrastructure.Models
{
    public class ResultResponse
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("next")]
        public string? Next { get; set; }

        [JsonProperty("previous")]
        public string? Previous { get; set; }

        [JsonProperty("results")]
        public List<MoveResponse>? Results { get; set; }
    }
}
