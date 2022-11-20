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

        public async Task<CityOfferDto> GetCityOffer(CityFormsDto forms)
        {
            var city = await _cityRepository.GetByForms(forms);

            var offer = city.BuildOffer();

            return offer;
        }
    }
}