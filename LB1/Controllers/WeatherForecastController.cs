using Microsoft.AspNetCore.Mvc;

namespace LB1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

        }

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> Get()
        {
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> Get(int id)
        {
        }

        [HttpPost]
        public ActionResult<Producto> Post([FromBody] Producto producto)
        {
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Producto producto)
        {
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Lógica para eliminar un producto por su ID
        }
    }
}