using CalculatorAPI.Models;
using CalculatorAPI.Services.Interfaces;

namespace CalculatorAPI.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double PerformCalculation(CalculationRequestModel request)
        {
            return request.Operation.ToLower() switch
            {
                "add" => request.FirstInput + request.SecondInput,
                "subtract" => request.FirstInput - request.SecondInput,
                "multiply" => request.FirstInput * request.SecondInput,
                "divide" => request.SecondInput != 0 ? request.FirstInput / request.SecondInput : throw new DivideByZeroException("Cannot divide by zero"),
                _ => throw new ArgumentException("Invalid operation")
            };
        }        
    }
}