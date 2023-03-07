
using System.Linq.Expressions;

namespace PokeDexBack.Application.Contracts
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetAsync(
                        Expression<Func<T, bool>> predicate = null,
                        int offset = 0,
                        int pageSize = 20,
                        string endpoint = ""
        );
    }
}
