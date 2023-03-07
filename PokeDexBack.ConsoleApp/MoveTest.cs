
using MediatR;
using PokeDexBack.Application.Features.Moves.Queries.GetMoves;
using PokeDexBack.Domain.Models;

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

        public async Task<List<Move>> ConsultMovement(int initiaOffset, int limit, string endpoint, int consulted = 0)
        {
            var result = new List<Move>();
            int taskNum = 10;
            if (consulted == 920)
            {
                return result;
            }
            else if ((920 - consulted) < 10)
            {
                taskNum = 920 - consulted;
            }

            Task<ResponseVm>[] vm = new Task<ResponseVm>[taskNum];

            var query = new GetMovesQuery()
            {
                Offset = initiaOffset,
                PageSize = limit
            };

            for (int i = 0; i < vm.Length; i++)
            {
                vm[i] = _mediator.Send(query);
                query.Offset += 20;
            }

            ICollection<ResponseVm> res = await Task.WhenAll(vm);

            res.ToList().ForEach(r => result.AddRange(r.Moves!));

            var concat = await ConsultMovement(query.Offset, query.PageSize, "move", consulted + result.Count);
            result.AddRange(concat);

            return result;
        }
    }
}
