using Microsoft.AspNetCore.Mvc;
using ShipShape.Application.Cities;
using ShipShape.Controllers.Dtos;

namespace ShipShape.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitiesController : ControllerBase
    {
        private ICityService _cityService;

        public CitiesController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet(Name = "GetCity")]
        public async Task<CityOfferDto> Get([FromBody] CityFormsDto dto)
        {
            return await _cityService.GetCityOffer(dto);
        }
    }
}