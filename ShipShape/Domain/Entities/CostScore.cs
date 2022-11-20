namespace ShipShape.Domain.Entities
{
    public class CostScore : Score
    {
        public int Food { get; set; }
        public int Stay { get; set; }
        public int entertainment { get; set; }

        private CostScore() { }

        public CostScore(int id, int cityId, int food, int stay, int entertainment) : base(id, cityId)
        {
            Food = food;
            Stay = stay;
            this.entertainment = entertainment;
        }
    }
}