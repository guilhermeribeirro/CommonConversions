using CommonConversions.Application.Services;

namespace CommonConversions.Application.UnitTestsWithNUnit.Services;

[TestFixture]
public class CommonConversionsServiceTests
{
    [Test]
    public void CelsiusToFahrenheit_ShouldReturn32_WhenInputIs0()
    {
        // Arrange
        var service = new ConversionService();
        double input = 0;

        // Act
        double result = service.CelsiusToFahrenheit(input);

        // Assert
        Assert.That(result, Is.EqualTo(32));
        //Assert.Equals(32, result);
    }

    [Test]
    public void KilometersToMiles_ShouldReturnExpectedValue_WhenInputIs1()
    {
        // Arrange
        var service = new ConversionService();
        
        // Act
        double result = service.KilometersToMiles(1);
        
        // Assert
        Assert.That(result, Is.EqualTo(0.621371).Within(0.00001));
    }

    [Test]
    public void KilogramsToPounds_ShouldReturnExpectedValue_WhenInputIs1()
    {
        // Arrange
        var service = new ConversionService();
        
        // Act
        double result = service.KilogramsToPounds(1);
        
        // Assert
        Assert.That(result, Is.EqualTo(2.20462).Within(0.00001));
    }
}