using ShipShape.Controllers.Dtos;
using ShipShape.Domain.Entities;

namespace ShipShape.Infra.Repositories.Cities
{
    public interface ICityRepository
    {
        Task<City> GetByForms(CityFormsDto forms);
    }
}