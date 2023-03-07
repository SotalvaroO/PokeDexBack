using PokeDexBack.Application.Contracts;
using PokeDexBack.Domain.Models;
using PokeDexBack.Infrastructure.Contracts;

namespace PokeDexBack.Infrastructure.Repositories
{
    public class ResultRepository: BaseRepository<Result>, IResultRepository
    {
        public ResultRepository(IApiClient<Result> apiClient):base(apiClient)
        {

        }
    }
}
