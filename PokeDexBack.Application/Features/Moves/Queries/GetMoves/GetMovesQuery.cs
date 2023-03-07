
using MediatR;

namespace PokeDexBack.Application.Features.Moves.Queries.GetMoves
{
    public class GetMovesQuery: IRequest<List<MovesVm>>
    {
        public int Offset { get; set; }
        public int PageSize { get; set; }
    }
}
