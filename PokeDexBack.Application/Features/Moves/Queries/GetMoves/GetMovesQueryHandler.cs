
using AutoMapper;
using MediatR;
using PokeDexBack.Application.Contracts;

namespace PokeDexBack.Application.Features.Moves.Queries.GetMoves
{
    public class GetMovesQueryHandler : IRequestHandler<GetMovesQuery, List<MovesVm>>
    {

        private readonly IMoveRepository _moveRepository;
        private readonly IMapper _mapper;

        public GetMovesQueryHandler(IMoveRepository moveRepository, IMapper mapper)
        {
            _moveRepository = moveRepository;
            _mapper = mapper;
        }

        public async Task<List<MovesVm>> Handle(GetMovesQuery request, CancellationToken cancellationToken)
        {
            var moves = await _moveRepository.GetAsync(offset: request.Offset, pageSize: request.PageSize);
            return _mapper.Map<List<MovesVm>>(moves);

        }
    }
}
