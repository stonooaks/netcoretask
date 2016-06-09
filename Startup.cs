using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace netcoretask
{
    public class Startup {

        public Startup(IHostingEnvironment env){
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }
        
        //This method gets called by the runtime. Use this method to add services
        public void ConfigureServices(IServiceCollection services){
            services.AddMvc();

            var connection = @"Server=afismahsqltest;Database=NetCoreTask;";
            services
                .AddEntityFramework()
                .AddEntityFrameworkSqlServer()
                .AddDbContext<TaskContext>(options => options.UseSqlServer(connection));
        }

        private IConfigurationRoot Configuration;
        public void Configure(IHostingEnvironment env, IApplicationBuilder app, ILoggerFactory loggerFactory)
        {

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
 
            app.UseStatusCodePages();

            app.UseStaticFiles();

            app.UseMvc();
       

            app.Run(async context => {
                await context.Response.WriteAsync("There is a problem with MVC");
            });
        }

      
    }
}