namespace APILayer.Models.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string? UserId { get; set; } // NULL nếu là thông báo toàn hệ thống
        public required string Title { get; set; }
        public required string Message { get; set; }
        public string? Type { get; set; } // info, warning, success, error
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }

        // Relationships
        public User? User { get; set; }
    }
}
