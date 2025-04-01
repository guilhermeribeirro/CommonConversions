namespace CommonConversions.Core.Domain;

public class ConvertHistory
{
    public ConvertHistory(string conversionType, double inputValue)
    {
        ConversionType = conversionType;
        InputValue = inputValue;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public string ConversionType { get; set; } = default!;
    public double InputValue { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public string PerformedBy { get; set; } = "sistema";
}