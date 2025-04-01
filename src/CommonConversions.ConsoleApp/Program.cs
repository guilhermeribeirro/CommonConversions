using CommonConversions.Application.Services;
using CommonConversions.Core.Interfaces;
using CommonConversions.Infrastructure;
using CommonConversions.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        var options = new DbContextOptionsBuilder<CommonConversionsDbContext>()
            .UseInMemoryDatabase("CommonConversionsDb")
            .Options;

        var dbContext = new CommonConversionsDbContext(options);
        IConvertHistoryRepository repository = new ConvertHistoryRepository(dbContext);
        var service = new ConversionService(repository);

        Console.WriteLine("=== Common Conversions ===");
        Console.WriteLine("Choose a conversion:");
        Console.WriteLine("1 - Celsius to Fahrenheit");
        Console.WriteLine("2 - Kilometers to Miles");
        Console.WriteLine("3 - Kilograms to Pounds");
        Console.WriteLine("4 - Exit");

        var choice = Console.ReadLine();

        while (choice != "4")
        {
            Console.Write("Enter the value to convert: ");
            var input = Console.ReadLine();

            if (double.TryParse(input, out double value))
            {
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result: {service.CelsiusToFahrenheit(value)} °F");
                        break;
                    case "2":
                        Console.WriteLine($"Result: {service.KilometersToMiles(value)} mi");
                        break;
                    case "3":
                        Console.WriteLine($"Result: {service.KilogramsToPounds(value)} lb");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine("\nChoose another conversion or 4 to exit:");
            choice = Console.ReadLine();
        }

        Console.WriteLine("Thanks for using CommonConversions!");
    }
}
