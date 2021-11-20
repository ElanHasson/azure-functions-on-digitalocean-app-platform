using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Azure.Functions.Worker.Configuration;

namespace azure_functions_on_digitalocean_app_platform
{
    public class Program
    {
        public static async Task Main()
        {
            await new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .RunConsoleAsync();

        }
    }
}