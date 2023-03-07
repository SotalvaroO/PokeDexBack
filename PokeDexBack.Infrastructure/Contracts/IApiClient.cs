
using System.Linq.Expressions;

namespace PokeDexBack.Infrastructure.Contracts
{
    public interface IApiClient<T>
    {
        Task<T> GetAsync(
                                        int offset = 0,
                                        int pageSize = 20,
                                        string endpoint = ""
        );
    }
}
