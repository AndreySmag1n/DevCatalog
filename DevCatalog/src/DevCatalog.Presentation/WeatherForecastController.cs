using Microsoft.AspNetCore.Mvc;

namespace DevCatalog.Presentation;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public void Test()
    {
        
    }
}