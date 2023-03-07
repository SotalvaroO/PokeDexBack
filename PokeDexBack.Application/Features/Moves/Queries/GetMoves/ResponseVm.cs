
using PokeDexBack.Domain.Models;

namespace PokeDexBack.Application.Features.Moves.Queries.GetMoves
{
    public class ResponseVm
    {
        public long Count { get; set; }
        public string? Next { get; set; }
        public string? Previous { get; set; }
        public List<Move>? Moves { get; set; }
    }
}
