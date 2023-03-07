
using MediatR;
using PokeDexBack.Application.Features.Moves.Queries.GetMoves;

namespace PokeDexBack.ConsoleApp
{
    public class MoveTest
    {
        private readonly IMediator _mediator;

        public MoveTest(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task GetMoves(int pageSize, int offset, string endpoint)
        {
            var query = new GetMovesQuery()
            {
                PageSize = pageSize,
                Offset = offset
            };
            var response = await _mediator.Send(query);
        }
    }
}
