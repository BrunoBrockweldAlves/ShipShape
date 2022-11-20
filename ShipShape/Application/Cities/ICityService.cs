using ShipShape.Controllers.Dtos;

namespace ShipShape.Application.Cities
{
    public interface ICityService
    {
        Task<CityOfferDto> GetCityOffer(CityFormsDto forms);
    }
}