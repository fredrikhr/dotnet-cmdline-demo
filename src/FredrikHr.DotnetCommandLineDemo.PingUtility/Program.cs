using System.CommandLine;
using System.CommandLine.Hosting;

using Microsoft.Extensions.Hosting;

CliRootCommand cliRoot = new();
CliConfiguration cliConfig = new(cliRoot);
cliConfig.UseHost(Host.CreateDefaultBuilder, ConfigureHost);
return await cliConfig.InvokeAsync(args ?? Array.Empty<string>())
    .ConfigureAwait(continueOnCapturedContext: false);

static void ConfigureHost(IHostBuilder host)
{
    host.RunConsoleAsync().Wait();
}
