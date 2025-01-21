using CalculatorAPI.Endpoints;
using CalculatorAPI.Services;
using CalculatorAPI.Services.Interfaces;
using Microsoft.Extensions.FileProviders;

namespace CalculatorAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Configure Service            
            builder.Services.AddScoped<ICalculatorService, CalculatorService>();

            var app = builder.Build();

            //Serving Index.html throw /Views folder
            app.UseStaticFiles("/Views");

            //Register API Endpoints
            app.RegisterCalclulatorEndpoints();            

            app.Run();
        }
    }
}