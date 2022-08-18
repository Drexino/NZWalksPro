namespace NZWalksPro.Models.Domains
{
    public class Regions
    {
        public Guid Id { get; set; }
        public string   Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public long Population { get; set; }

        //Navigation prperties
        public IEnumerable<Walk> walks { get; set; }

    }
}
