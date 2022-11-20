namespace ShipShape.Domain.Entities
{
    public abstract class Score
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public virtual City City { get;}

        public Score() { }

        public Score(int id, int cityId) 
        {
            Id = id;
            CityId = cityId;
        }
    }
}