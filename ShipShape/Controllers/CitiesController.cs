using Microsoft.AspNetCore.Mvc;
using ShipShape.Controllers.Dtos;

namespace ShipShape.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitiesController : ControllerBase
    {

        public CitiesController()
        {
        }

        [HttpGet(Name = "GetCity")]
        public CityOfferDto Get([FromBody] CityFormsDto dto)
        {
            //TODO Implementar 
            return default;
        }
    }
}