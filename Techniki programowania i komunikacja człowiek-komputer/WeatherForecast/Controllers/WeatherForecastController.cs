using Microsoft.AspNetCore.Mvc;

namespace WeatherForecast.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static DateTime today = DateTime.Now;

        private static readonly string[] Cities = new[]
        {
        "Warszawa", "Gdañsk", "£ódŸ", "Kraków", "Bydgoszcz", "Katowice", "Olsztyn", "Szczecin", "Poznañ"
        };
        private static string randomCity = Cities[Random.Shared.Next(Cities.Length)];
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast_Poland> Get()
        {
            return Enumerable.Range(0, 2).Select(index =>
            {
            int temperature = randomTemp(today.AddDays(index));
                return new WeatherForecast_Poland
                {
                    City = randomCity,
                    Date = DateOnly.FromDateTime(today.AddDays(index)),
                    TemperatureC = temperature,
                    Summary = GetTemperatureSummary(temperature)
                };
            })
            .ToArray();
        }

        public static int randomTemp(DateTime today)
        {
            int month = today.Month;
            if (month >= 3 && month <= 5) return Random.Shared.Next(5, 20);
            else if (month >= 6 && month <= 8) return Random.Shared.Next(15, 35);
            else if (month >= 9 && month <= 11) return Random.Shared.Next(0, 15);
            else return Random.Shared.Next(-15, 5);
        }
        public static string GetTemperatureSummary(int temperature)
        {
            if (temperature >= 35) return "Scorching";
            else if (temperature >= 30) return "Sweltering";
            else if (temperature >= 25) return "Hot";
            else if (temperature >= 20) return "Balmy";
            else if (temperature >= 15) return "Warm";
            else if (temperature >= 10) return "Mild";
            else if (temperature >= 5) return "Cool";
            else if (temperature >= 0) return "Chilly";
            else if (temperature >= -5) return "Bracing";
            else return "Freezing";
        }
    }
}