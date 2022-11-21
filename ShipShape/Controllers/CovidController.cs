using Microsoft.AspNetCore.Mvc;
using ShipShape.Application.Covid;

namespace ShipShape.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CovidController : ControllerBase
    {
        private ICovidService _covidService;

        public CovidController(ICovidService covidService)
        {
            _covidService = covidService;
        }

        [HttpGet(Name = "GetToken/{country}")]
        public async Task<string> Get([FromQuery] string country)
        {
            return await _covidService.GetAsync(country);
        }
    }
}