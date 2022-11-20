namespace ShipShape.Domain.Entities
{
    public class RestrictionScore : Score
    {
        public int Accessibility { get; set; }
        public int PetFriendly { get; set; }
        public int KidFriendly { get; set; }

        private RestrictionScore() { }

        public RestrictionScore(int id, int cityId, int accessibility, int petFriendly, int kidFriendly) : base(id, cityId)
        {
            Accessibility = accessibility;
            PetFriendly = petFriendly;
            KidFriendly = kidFriendly;
        }
    }
}