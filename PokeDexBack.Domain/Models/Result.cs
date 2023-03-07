
namespace PokeDexBack.Domain.Models
{
    public class Result
    {
        public long Count { get; set; }
        public string? Next { get; set; }
        public string? Previous { get; set; }
        public List<Move>? Results { get; set; }
    }
}
