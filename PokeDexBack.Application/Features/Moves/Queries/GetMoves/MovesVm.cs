
using PokeDexBack.Domain.Models;

namespace PokeDexBack.Application.Features.Moves.Queries.GetMoves
{
    public class MovesVm
    {
        //[JsonProperty("count")]
        public long Count { get; set; }

        //[JsonProperty("next")]
        public string? Next { get; set; }

        //[JsonProperty("previous")]
        public string? Previous { get; set; }

        //[JsonProperty("results")]
        public List<Move>? Results { get; set; }
    }
}
