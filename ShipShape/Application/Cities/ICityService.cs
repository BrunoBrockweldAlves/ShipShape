using ShipShape.Controllers.Dtos;

namespace ShipShape.Application.Cities
{
    public interface ICityService
    {
        CityOfferDto GetCityOffer(CityFormsDto forms);
    }
}