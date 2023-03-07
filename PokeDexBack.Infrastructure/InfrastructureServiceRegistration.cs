
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PokeDexBack.Application.Contracts;
using PokeDexBack.Infrastructure.Clients;
using PokeDexBack.Infrastructure.Contracts;
using PokeDexBack.Infrastructure.Models;
using PokeDexBack.Infrastructure.Repositories;

namespace PokeDexBack.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IResultRepository), typeof(ResultRepository));
            services.AddHttpClient();
            services.AddScoped(typeof(IApiClient<>), typeof(BaseHttpClient<>));
            services.Configure<ApiSettings>(c => config.GetSection("ApiSettings"));
            var conn = config.GetSection("ApiSettings").GetSection("UrlString").Value;
            return services;
        }
    }
}
