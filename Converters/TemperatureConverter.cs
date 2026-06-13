namespace UnitConversionApi.Converters;

public class TemperatureConverter : IUnitConverter
{
    private readonly HashSet<string> _units =
        new()
        {
            "celsius",
            "fahrenheit",
            "kelvin"
        };

    public bool CanConvert(string fromUnit, string toUnit)
    {
        return _units.Contains(fromUnit.ToLower()) &&
               _units.Contains(toUnit.ToLower());
    }

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        double celsius = fromUnit.ToLower() switch
        {
            "celsius" => value,
            "fahrenheit" => (value - 32) * 5 / 9,
            "kelvin" => value - 273.15,
            _ => throw new ArgumentException("Unsupported temperature unit.")
        };

        return toUnit.ToLower() switch
        {
            "celsius" => celsius,
            "fahrenheit" => (celsius * 9 / 5) + 32,
            "kelvin" => celsius + 273.15,
            _ => throw new ArgumentException("Unsupported temperature unit.")
        };
    }
}