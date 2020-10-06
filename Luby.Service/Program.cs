using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using static System.Console;
using Luby.Service.Configurations;
using System;

namespace Luby.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var Configuration = InjectionConfiguration.configurationRoot();

                var porta = Configuration["ConnectionStrings:portaHost"] + "";

                var host = new WebHostBuilder()
                    .UseKestrel()
                    .UseUrls(porta)
                    .UseStartup<Startup>()
                    .Build();

                host.Run();
            }
            catch (Exception erro)
            {
                WriteLine("Erro Program: " + erro.Message);
                ReadLine();
            }
        }
    }
}
