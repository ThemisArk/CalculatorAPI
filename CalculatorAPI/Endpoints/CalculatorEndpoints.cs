using System.Runtime.CompilerServices;
using CalculatorAPI.Models;
using CalculatorAPI.Services;
using CalculatorAPI.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace CalculatorAPI.Endpoints
{
    public static class CalculatorEndpoints
    {
        public static void RegisterCalclulatorEndpoints(this WebApplication app)
        {
            app.MapGet("/", async context =>
            {
                context.Response.ContentType = "text/html";
                await context.Response.SendFileAsync("Views/Index.html");
            });

            app.MapPost("/calculate", (CalculationRequestModel request, ICalculatorService calculate) =>
            {
                try
                {
                    var result = calculate.PerformCalculation(request);
                    return Results.Ok(new {Result = result});
                }
                catch(Exception ex)
                {
                    return Results.BadRequest(new {Error = ex.Message});
                }
            });
        }    
    }
}