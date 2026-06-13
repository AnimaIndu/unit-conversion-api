namespace UnitConversionApi.Converters;

public class WeightConverter : IUnitConverter
{
    private readonly Dictionary<string, double> _weights =
        new()
        {
            { "kilogram", 1 },
            { "gram", 0.001 },
            { "pound", 0.453592 }
        };

    public bool CanConvert(string fromUnit, string toUnit)
    {
        return _weights.ContainsKey(fromUnit.ToLower()) &&
               _weights.ContainsKey(toUnit.ToLower());
    }

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        var valueInKilograms =
            value * _weights[fromUnit.ToLower()];

        return valueInKilograms /
               _weights[toUnit.ToLower()];
    }
}