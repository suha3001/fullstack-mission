// ใช้งานคลาสและไลบรารีที่เกี่ยวข้อง
using chat_sv.Models;
using Microsoft.AspNetCore.Mvc;

// กำหนด namespace ของ Controller
namespace chat_sv.Controllers;

// ประกาศคลาส SuhaController ซึ่งเป็น ControllerBase สำหรับ API
[ApiController]
[Route("api/v1")]
public class SuhaController : ControllerBase
{
    // กำหนดข้อมูลสภาพอากาศ
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    // ประกาศตัวแปรในคลาส
    private readonly ILogger<SuhaController> _logger;

    // Constructor ของคลาส SuhaController ที่รับ dependency injection ของ ILogger
    public SuhaController(ILogger<SuhaController> logger)
    {
        _logger = logger;
    }

    // ประกาศ API Endpoint สำหรับ HTTP GET
    [HttpGet(Name = "GetWeatherForecast")]
    [Route("members")]
    public IEnumerable<WeatherForecast> Get([FromQuery] SuhaParams suhaParams, [FromRoute] SuhaRoute suhaRoute, [FromBody] SuhaBody suhaBody)
    {
        _logger.LogInformation(suhaParams.Id);
        _logger.LogInformation(suhaParams.Name);
        _logger.LogInformation(suhaRoute.Id);
        _logger.LogInformation(suhaBody.UserName);

        // สร้างลิสต์ข้อมูลสภาพอากาศ
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            // กำหนดข้อมูลของแต่ละวัน
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        // แปลงเป็น Array และคืนค่า
        .ToArray();
    }
}
