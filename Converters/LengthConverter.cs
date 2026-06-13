namespace UnitConversionApi.Converters;

public class LengthConverter : IUnitConverter
{
    private readonly Dictionary<string, double> _units =
        new()
        {
            { "meter", 1 },
            { "kilometer", 1000 },
            { "foot", 0.3048 },
            { "inch", 0.0254 }
        };

    public bool CanConvert(string fromUnit, string toUnit)
    {
        return _units.ContainsKey(fromUnit.ToLower()) &&
               _units.ContainsKey(toUnit.ToLower());
    }

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        var valueInMeters =
            value * _units[fromUnit.ToLower()];

        return valueInMeters /
               _units[toUnit.ToLower()];
    }
}