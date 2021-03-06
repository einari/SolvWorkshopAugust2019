﻿using System.Threading.Tasks;
using Dolittle.Booting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Fundamentals
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Standard .NET Core Host
            var hostBuilder = new HostBuilder();
            hostBuilder.ConfigureLogging(_ =>
            {
                _.AddConsole();
            });
            hostBuilder.UseEnvironment("Development");
            var host = hostBuilder.Build();
            var loggerFactory = host.Services.GetService(typeof(ILoggerFactory)) as ILoggerFactory;

            // Boot Dolittle
            var result = Bootloader.Configure(_ =>
            {
                _.UseLoggerFactory(loggerFactory);
                _.Development();
            }).Start();

            // Get our IFoo service
            var foo = result.Container.Get<IFoo>();

            await host.RunAsync();
        }
    }
}