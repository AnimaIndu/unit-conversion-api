namespace UnitConversionApi.Converters;

public interface IUnitConverter
{
    bool CanConvert(string fromUnit, string toUnit);

    double Convert(
        double value,
        string fromUnit,
        string toUnit);
}