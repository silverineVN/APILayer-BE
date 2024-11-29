using APILayer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace APILayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
        public DbSet<NewsletterSubscription> NewsletterSubscriptions { get; set; }
        public DbSet<API> APIs { get; set; }
        public DbSet<APIVersion> APIVersions { get; set; }
        public DbSet<APIDocumentation> APIDocumentations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<FeaturedAPI> FeaturedAPIs { get; set; }
        public DbSet<Notification> Notifications { get; set; }

    }
}
