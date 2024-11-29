namespace APILayer.Models.Entities
{
    public class NewsletterSubscription
    {
        public int SubscriptionId { get; set; }
        public required string Email { get; set; }
        public DateTime SubscribedAt { get; set; }
        public string? Status { get; set; }
    }
}
