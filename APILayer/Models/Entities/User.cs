
namespace APILayer.Models.Entities
{
    public class User
    {
        public required string UserId { get; set; }
        public required string Email { get; set;}
        public string? Username { get; set;}
        public string? Password { get; set;}
        public string? FullName { get; set;}
        public string Role { get; set; } = "Customer"; // Provider, Admin
        public string? Provider { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Relationships
        public ICollection<Payment>? Payments { get; set; }
        public ICollection<UserSubscription>? UserSubscriptions { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<FAQ>? FAQs { get; set; }
    }
}
