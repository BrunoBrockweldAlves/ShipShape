using Dapper;
using MeuCampeonatoAPI.Domain.Data.Context;
using Microsoft.EntityFrameworkCore;
using ShipShape.Controllers.Dtos;
using ShipShape.Domain.Entities;

namespace ShipShape.Infra.Repositories.Cities
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _context;

        public CityRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<City>> GetAll()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City> GetByForms(CityFormsDto forms)
        {
            var sql = @$"SELECT TOP 1 
                            Id,
                            Name
                         FROM City
                         WHERE Id NOT IN (@RefusedCities)
                            GROUP BY Id
                         ORDER BY SUM(@ChosenTags) DESC";

            var parameters = new
            {
                RefusedCities = forms.RefusedCities,
                ChosenTags = forms.ChosenTags
            };

            return await _context.Database.GetDbConnection().QueryFirstAsync<City>(sql, parameters);
        }
    }
}