using Microsoft.AspNetCore.Mvc;

namespace UnitConversionApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConversionController : ControllerBase
{
    private readonly IConversionService _service;

    public ConversionController(IConversionService service)
    {
        _service = service;
    }

    [HttpPost("convert")]
    public IActionResult Convert([FromBody] ConvertRequest request)
    {
        try
        {
            var result = _service.Convert(
                request.Value,
                request.FromUnit,
                request.ToUnit);

            return Ok(new ConvertResponse
            {
                OriginalValue = request.Value,
                FromUnit = request.FromUnit,
                ToUnit = request.ToUnit,
                ConvertedValue = result
            });
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new
            {
                Error = ex.Message
            });
        }
    }
}