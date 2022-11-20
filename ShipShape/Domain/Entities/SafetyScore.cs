namespace ShipShape.Domain.Entities
{
    public class SafetyScore : Score
    {
        public int LgbtqiaPlus { get; set; }
        public int Medical { get; set; }
        public int Overall { get; set; }
        public int PhysicalHarm { get; set; }

        private SafetyScore() { }

        public SafetyScore(int id, int cityId, int lgbtqiaPlus, int medical, int overall, int physicalHarm) : base(id, cityId)
        {
            LgbtqiaPlus = lgbtqiaPlus;
            Medical = medical;
            Overall = overall;
            PhysicalHarm = physicalHarm;
        }
    }
}