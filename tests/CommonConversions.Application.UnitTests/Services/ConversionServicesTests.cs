using CommonConversions.Application.Services;

namespace CommonConversions.Application.UnitTests.Services;

public class ConversionServiceTests
{

    [Fact]
    public void CelsiusToFahrenheit_ShouldConvertCorrectly()
    {
        // Arrange
        var service = new ConversionService();
        double input = 0;

        // Act
        double result = service.CelsiusToFahrenheit(input);

        // Assert
        Assert.Equal(32, result);
    }

    [Fact]
    public void KilometersToMiles_ShouldConvertCorrectly()
    {
        // Arrange
        var service = new ConversionService();

        // Act
        double result = service.KilometersToMiles(1);

        // Assert
        Assert.Equal(0.621371, result, 5);
    }

    [Fact]
    public void KilogramsToPounds_ShouldConvertCorrectly()
    {
        // Arrange
        var service = new ConversionService();

        // Act
        double result = service.KilogramsToPounds(1);

        // Assert
        Assert.Equal(2.20462, result, 5);
    }
}