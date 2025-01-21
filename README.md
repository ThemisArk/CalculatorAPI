# CalculatorAPI

This is a simple API-based calculator built with **ASP.NET Core** that allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division via HTTP endpoints. The project is structured to follow best practices, separating concerns into models, services, and API layers for easy maintainability and scalability.

The project is organized into the following key folders:

- **`Endpoints`**: Contains the API endpoints that define the operations users can interact with (e.g., add, subtract).
- **`Views`**: Holds the `Index.html` file, providing a basic user interface for interacting with the calculator.
- **`Models`**: Includes the `CalculationRequestModel`, which defines the structure for data sent to the API.
- **`Services`**: Contains the `CalculatorService`, which holds the business logic to perform the calculations.
- **`Interfaces`**: Defines the `ICalculatorService` interface that the service implements.

- ## Supported Operations:
  
- add: Adds two numbers.
- subtract: Subtracts the second number from the first.
- multiply: Multiplies two numbers.
- divide: Divides the first number by the second (returns error if division by zero).

- ## How to Run

1. Clone this repository to your local machine.
2. Open the project in **Visual Studio**.
3. Ensure all dependencies are restored by restoring **NuGet packages**.
4. Press **F5** or use the **Run** button in Visual Studio to start the application.
5. Use an API client like **Postman** or **Insomnia** to interact with the API endpoints, or open the `Index.html` file in a browser to use the calculator UI.

- ## License
This project is licensed under the MIT License - see the LICENSE file for details.
