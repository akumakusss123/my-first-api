using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NamesController : ControllerBase
    {
        private static List<string> names = new List<string> { "Иван", "Мария", "Петр" };

        [HttpGet]
        public IActionResult Get() => Ok(names);

        [HttpPost]
        public IActionResult Add([FromBody] string name)
        {
            names.Add(name);
            return Ok($"Добавлено: {name}");
        }
    }
}
