using CommonConversions.Application.Services;

namespace CommonConversions.Application.UnitTestsWithMSTest.Services;

[TestClass]
public sealed class CommonConversionsServiceTest
{
    [TestMethod]
    public void CelsiusToFahrenheit_ShouldReturn32_WhenInputIs0()
    {
        // Arrange
        var service = new ConversionService();
        double input = 0;

        // Act
        double result = service.CelsiusToFahrenheit(input);

        // Assert
        Assert.AreEqual(32, result);
    }

    [TestMethod]
    public void KilometersToMiles_ShouldReturnExpectedValue_WhenInputIs1()
    {
        // Arrange
        var service = new ConversionService();
        
        // Act
        double result = service.KilometersToMiles(1);
        
        // Assert
        Assert.AreEqual(0.621371, result, 0.00001);
    }

    [TestMethod]
    public void KilogramsToPounds_ShouldReturnExpectedValue_WhenInputIs1()
    {
        // Arrange
        var service = new ConversionService();
        
        // Act
        double result = service.KilogramsToPounds(1);
        
        // Assert
        Assert.AreEqual(2.20462, result, 0.00001);
    }
}
