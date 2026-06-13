using UnitConversionApi.Converters;

namespace UnitConversionApi.Services;

public class ConversionService : IConversionService
{
    private readonly IEnumerable<IUnitConverter> _converters;

    public ConversionService(
        IEnumerable<IUnitConverter> converters)
    {
        _converters = converters;
    }

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        var converter = _converters.FirstOrDefault(
            c => c.CanConvert(fromUnit, toUnit));

        if (converter == null)
        {
            throw new ArgumentException(
                $"Conversion from '{fromUnit}' to '{toUnit}' is not supported.");
        }

        return converter.Convert(
            value,
            fromUnit,
            toUnit);
    }
}