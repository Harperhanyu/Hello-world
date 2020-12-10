using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace APIdemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((webHostBuilder, configurationBuilder) =>
                {
                    configurationBuilder.AddEnvironmentVariables();
                    //configurationBuilder.AddJsonFile("appsettings.json", true);
                    configurationBuilder.AddJsonFile($"appsettings.{webHostBuilder.HostingEnvironment.EnvironmentName}.json", true);
                })
                .UseStartup<Startup>();
    }
}
