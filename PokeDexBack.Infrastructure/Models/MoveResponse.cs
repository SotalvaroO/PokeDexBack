
using Newtonsoft.Json;
using PokeDexBack.Domain.Models;

namespace PokeDexBack.Infrastructure.Models
{
    public class MoveResponse
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
