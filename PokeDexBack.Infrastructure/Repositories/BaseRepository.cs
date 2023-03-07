
using PokeDexBack.Application.Contracts;
using PokeDexBack.Infrastructure.Contracts;
using System.Linq.Expressions;

namespace PokeDexBack.Infrastructure.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {

        private readonly IApiClient<T> _apiClient;

        public BaseRepository(IApiClient<T> apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate = null, int offset = 0, int pageSize = 20, string endpoint = "")
        {
            return await _apiClient.GetAsync(offset, pageSize, endpoint);
        }
    }
}
