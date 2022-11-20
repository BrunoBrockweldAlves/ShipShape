using Dapper;
using Microsoft.EntityFrameworkCore;
using ShipShape.Domain.Entities;

namespace MeuCampeonatoAPI.Domain.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<City> Cities { get; set; }
    }
}