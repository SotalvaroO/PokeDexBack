using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PokeDexBack.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = new ServiceCollection()
                .BuildServiceProvider();

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration config = builder.Build();

            var conn = config.GetSection("ApiSettings").GetSection("UrlString").Value;
        }
    }
}