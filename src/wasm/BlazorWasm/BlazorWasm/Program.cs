using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Blazor.Extensions.Logging;

namespace BlazorWasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

           
            builder.RootComponents.Add<App>("app");
            //builder.HostEnvironment
            //builder.Logging
            //builder.Configuration
          
            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        
            builder.Services.AddTransient(sp => new WeatherClient { BaseAddress = new Uri("http://localhost:7071") });


            //builder.Services.AddAuthorizationCore
            //builder.Services.AddOptions

            await builder.Build().RunAsync();
        }
    }
}
