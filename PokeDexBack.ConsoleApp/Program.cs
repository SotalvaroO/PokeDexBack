using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PokeDexBack.Application;
using PokeDexBack.Infrastructure;

namespace PokeDexBack.ConsoleApp
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            var serviceCollection = new ServiceCollection()
                .AddApplicationServices()
                .AddInfrastructureServices(config)
                .BuildServiceProvider();

            var mediaTr = new MoveTest(serviceCollection.GetService<IMediator>());
            await mediaTr.GetMoves(3,0,"move");

        }
    }
}