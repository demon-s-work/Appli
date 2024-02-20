using Appli.Dal.Context;
using Microsoft.EntityFrameworkCore;

namespace Mapd.Server
{
	public class Startup
	{
		protected IConfiguration Configuration { get; }
		
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public virtual void ConfigureServices(IServiceCollection services)
        {
	        var connectionString = Configuration.GetConnectionString("DefaultConnection");
	        services.AddDbContext<ApplicationDbContext>(options => options.UseMySQL(connectionString));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
	        
        }
	}
}