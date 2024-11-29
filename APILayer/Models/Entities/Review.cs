namespace APILayer.Models.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public required string UserId { get; set; }
        public int ApiId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime ReviewDate { get; set; }

        // Relationships
        public User? User { get; set; }
        public API? Api { get; set; }
    }
}
