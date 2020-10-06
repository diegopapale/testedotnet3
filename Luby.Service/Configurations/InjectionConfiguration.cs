using Microsoft.Extensions.Configuration;
using System.IO;

namespace Luby.Service.Configurations
{
    public static class InjectionConfiguration
    {
        public static IConfigurationRoot configurationRoot()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            IConfigurationRoot Configuration = builder.Build();

            return Configuration;
        }
    }
}
