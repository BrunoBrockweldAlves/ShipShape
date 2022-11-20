using ShipShape.Controllers.Dtos;

namespace ShipShape.Domain.Entities
{
    public class City
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public virtual CostScore CostScore { get; set; }
        public virtual EnvironmentScore EnvironmentScore { get; set; }
        public virtual RestrictionScore RestrictionScore { get; set; }
        public virtual SafetyScore SafetyScore { get; set; }

        private City() { }

        public City(int id, int name, int latitude, int longitude)
        {
            Id = id;
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }

        public CityOfferDto BuildOffer() => new() { Id = Id, Name = Name};
    }
}