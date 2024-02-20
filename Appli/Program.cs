using Microsoft.AspNetCore;

namespace Mapd.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) => { config.AddEnvironmentVariables("APPLI_"); })
                .Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                          .UseStartup<Startup>().ConfigureKestrel((context, options) => {});
        }
    }
}