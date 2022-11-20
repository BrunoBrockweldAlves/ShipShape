using ShipShape.Controllers.Dtos;
using ShipShape.Domain.Entities;
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
            //TODO implementar banco
            //var city = await _cityRepository.GetByForms(forms);
            var city = new City(1, "NovaYork", 1,1);

            var offer = city.BuildOffer();

            return offer;
        }
    }
}