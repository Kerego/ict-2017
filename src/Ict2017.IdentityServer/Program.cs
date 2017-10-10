using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ict2017.Common;
using IdentityServer4.EntityFramework.DbContexts;
using IdentityServerWithAspNetIdentity.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

namespace IdentityServerWithAspNetIdentity
{
    public class Program
    {
        public static void Main(string[] args) =>
            BuildWebHost(args)
                .Migrate<PersistedGrantDbContext>()
                .Migrate<ApplicationDbContext>()
                .Run();

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
