namespace ShipShape.Application.Covid
{
    public interface ICovidService
    {
        Task<string> GetAsync(string country);
    }
}
