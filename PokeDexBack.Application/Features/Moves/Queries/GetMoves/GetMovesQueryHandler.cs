
using AutoMapper;
using MediatR;
using PokeDexBack.Application.Contracts;

namespace PokeDexBack.Application.Features.Moves.Queries.GetMoves
{
    public class GetMovesQueryHandler : IRequestHandler<GetMovesQuery, ResponseVm>
    {

        private readonly IResultRepository _resultRepository;
        private readonly IMapper _mapper;

        public GetMovesQueryHandler(IResultRepository resultRepository, IMapper mapper)
        {
            _resultRepository = resultRepository;
            _mapper = mapper;
        }

        public async Task<ResponseVm> Handle(GetMovesQuery request, CancellationToken cancellationToken)
        {
            var result = await _resultRepository.GetAsync(offset: request.Offset, pageSize: request.PageSize, endpoint: "move");
            return _mapper.Map<ResponseVm>(result);

        }
    }
}
