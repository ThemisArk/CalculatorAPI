using System.ComponentModel.DataAnnotations;

namespace CalculatorAPI.Models
{
    public class CalculationRequestModel
    {
        public double FirstInput {  get; set; }
        public double SecondInput { get; set; }
        [Required(ErrorMessage="Please select an operation")]
        public string? Operation { get; set; }
    }
}
