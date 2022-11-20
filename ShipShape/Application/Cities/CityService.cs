using ShipShape.Controllers.Dtos;
using ShipShape.Infra.Repositories.Cities;

namespace ShipShape.Application.Cities
{
    public class CityService : ICityService
    {
        private ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public CityOfferDto GetCityOffer(CityFormsDto forms)
        {
            return default;
        }
    }
}