using System;

class TemperatureConverter
{
    static void Main(string[] args)
    {
        char choice = 'Y';
        do
        {
            Console.WriteLine("Choose the temperature scale to convert from:");
            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Fahrenheit");
            Console.Write("Enter your choice: ");
            int scaleChoice = int.Parse(Console.ReadLine());

            double temperature;
            double convertedTemperature;

            if (scaleChoice == 1)
            {
                Console.Write("Enter the temperature in Celsius: ");
                temperature = double.Parse(Console.ReadLine());
                convertedTemperature = CelsiusToFahrenheit(temperature);
                Console.WriteLine($"{temperature}°C is equal to {convertedTemperature}°F.");
            }
            else if (scaleChoice == 2)
            {
                Console.Write("Enter the temperature in Fahrenheit: ");
                temperature = double.Parse(Console.ReadLine());
                convertedTemperature = FahrenheitToCelsius(temperature);
                Console.WriteLine($"{temperature}°F is equal to {convertedTemperature}°C.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                continue;
            }

            Console.Write("Do you want to convert another temperature? (Y/N): ");
            choice = Console.ReadLine().ToUpper()[0];
        }
        while (choice == 'Y');
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
