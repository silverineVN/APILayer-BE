namespace APILayer.Models.Entities
{
    public class FAQ
    {
        public int FaqId { get; set; }
        public required string Question { get; set; }
        public string? Answer { get; set; }
        public string? Category { get; set; }

        // Relationships
        public required string UserId { get; set; }
        public User? User { get; set; }
    }
}
