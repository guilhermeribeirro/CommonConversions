using CommonConversions.Core.Domain;
using CommonConversions.Core.Interfaces;

namespace CommonConversions.Application.Services;

public class ConversionService
{
    private readonly IConvertHistoryRepository _repository;
    public ConversionService(IConvertHistoryRepository repository)
    {
        _repository = repository;
    }
    public ConversionService()
    {
            
    }

    public double CelsiusToFahrenheit(double celsius)
    {
        var result =  (celsius * 9 / 5) + 32;

        var history = new ConvertHistory(nameof(CelsiusToFahrenheit), celsius);

        _repository.SaveAsync(history);
        return result;

    }

    public double KilometersToMiles(double km)
    {
        var result = km * 0.621371;

        var history = new ConvertHistory(nameof(KilometersToMiles), km);

        _repository.SaveAsync(history);
        return result;
    }

    public double KilogramsToPounds(double kg)
    {
        var result = kg * 2.20462;

        var history = new ConvertHistory(nameof(KilogramsToPounds), kg);

        _repository.SaveAsync(history);
        return result;
    }
}
