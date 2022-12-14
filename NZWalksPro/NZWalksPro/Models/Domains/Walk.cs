namespace NZWalksPro.Models.Domains
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name  { get; set; }
        public string Length { get; set; }
        
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        //Navigation Properties
        public Regions Regions { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }
    }
}
