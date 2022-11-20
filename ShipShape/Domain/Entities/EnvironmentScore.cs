namespace ShipShape.Domain.Entities
{
    public class EnvironmentScore : Score
    {
        public int Beach { get; set; }
        public int Mountain { get; set; }
        public int Field { get; set; }

        private EnvironmentScore() { }

        public EnvironmentScore(int id, int cityId, int beach, int mountain, int field) : base(id, cityId)
        {
            Beach = beach;
            Mountain = mountain;
            Field = field;
        }
    }
}