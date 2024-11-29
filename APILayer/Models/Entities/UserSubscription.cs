namespace APILayer.Models.Entities
{
    public class UserSubscription
    {
        public int SubscriptionId { get; set; }
        public int UserId { get; set; }
        public string? SubscriptionType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PaymentStatus { get; set; } = "Pending";

        // Relationships
        public User? User { get; set; }
    }
}
