namespace APILayer.Models.Entities
{
    public class FeaturedAPI
    {
        public int FeaturedApiId { get; set; }
        public int ApiId { get; set; }
        public required string UserId { get; set; }
        public string? ReasonForFeature { get; set; }
        public DateTime FeaturedFrom { get; set; }
        public DateTime FeaturedTo { get; set; }

        // Relationships
        public API? Api { get; set; }
        public User? User { get; set; }
    }
}
