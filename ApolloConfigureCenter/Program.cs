using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Com.Ctrip.Framework.Apollo;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ApolloConfigureCenter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, builder) =>
                {
                    builder
                   .AddApollo(builder.Build().GetSection("apollo"))
                   .AddDefault() //默认的application Namespace
                   .AddNamespace("Private_Louie_Swagger"); //private 类型的Namespace
                })
                .UseStartup<Startup>()
                .Build();
    }
}
