namespace APILayer.Models.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public required string UserId { get; set; }
        public int ApiId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = "VNPay";
        public string PaymentStatus { get; set; } = "Pending";
        public DateTime PaymentDate { get; set; }

        // Relationships
        public required User User { get; set; }
        public required API Api { get; set; }
    }
}
