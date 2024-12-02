namespace APILayer.Models.Entities
{
    public class UserSubscription
    {
        public int SubscriptionId { get; set; }
        public required string UserId { get; set; }
        public required int ApiId { get; set; }
        public string? SubscriptionType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PaymentStatus { get; set; } = "Pending";

        // Relationships
        public User? User { get; set; }
        public API? Api { get; set; }
    }
}
