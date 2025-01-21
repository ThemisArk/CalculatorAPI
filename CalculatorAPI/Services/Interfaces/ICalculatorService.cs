using CalculatorAPI.Models;

namespace CalculatorAPI.Services.Interfaces
{
    public interface ICalculatorService
    {
        public double PerformCalculation(CalculationRequestModel request);
    }
}
