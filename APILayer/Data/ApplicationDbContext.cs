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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User Entity Configuration
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);
            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            // API Entity Configuration
            modelBuilder.Entity<API>()
                .HasKey(a => a.ApiId);
            modelBuilder.Entity<API>()
                .HasOne(a => a.Owner)
                .WithMany()
                .HasForeignKey(a => a.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            // APIDocumentation Entity Configuration
            modelBuilder.Entity<APIDocumentation>()
                .HasKey(d => d.DocumentationId);
            modelBuilder.Entity<APIDocumentation>()
                .HasOne(d => d.Api)
                .WithMany(a => a.Documentations)
                .HasForeignKey(d => d.ApiId)
                .OnDelete(DeleteBehavior.Cascade);

            // APIVersion Entity Configuration
            modelBuilder.Entity<APIVersion>()
                .HasKey(v => v.VersionId);
            modelBuilder.Entity<APIVersion>()
                .HasOne(v => v.Api)
                .WithMany(a => a.Versions)
                .HasForeignKey(v => v.ApiId)
                .OnDelete(DeleteBehavior.Cascade);

            // Payment Entity Configuration
            modelBuilder.Entity<Payment>()
                .HasKey(p => p.PaymentId);
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.User)
                .WithMany(u => u.Payments)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Api)
                .WithMany()
                .HasForeignKey(p => p.ApiId)
                .OnDelete(DeleteBehavior.Restrict);

            // UserSubscription Entity Configuration
            modelBuilder.Entity<UserSubscription>()
                .HasKey(us => us.SubscriptionId);
            modelBuilder.Entity<UserSubscription>()
                .HasOne(us => us.User)
                .WithMany(u => u.UserSubscriptions)
                .HasForeignKey(us => us.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Review Entity Configuration
            modelBuilder.Entity<Review>()
                .HasKey(r => r.ReviewId);
            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Api)
                .WithMany(a => a.Reviews)
                .HasForeignKey(r => r.ApiId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Review>()
                .Property(r => r.Rating)
                .HasMaxLength(5);

            // FAQ Entity Configuration
            modelBuilder.Entity<FAQ>()
                .HasKey(f => f.FaqId);
            modelBuilder.Entity<FAQ>()
                .HasOne(f => f.User)
                .WithMany(u => u.FAQs)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // FeaturedAPI Entity Configuration
            modelBuilder.Entity<FeaturedAPI>()
                .HasKey(fa => fa.FeaturedApiId);
            modelBuilder.Entity<FeaturedAPI>()
                .HasOne(fa => fa.Api)
                .WithMany(a => a.FeaturedAPIs)
                .HasForeignKey(fa => fa.ApiId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<FeaturedAPI>()
                .HasOne(fa => fa.User)
                .WithMany()
                .HasForeignKey(fa => fa.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Notification Entity Configuration
            modelBuilder.Entity<Notification>()
                .HasKey(n => n.NotificationId);
            modelBuilder.Entity<Notification>()
                .HasOne(n => n.User)
                .WithMany()
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // NewsletterSubscription Entity Configuration
            modelBuilder.Entity<NewsletterSubscription>()
                .HasKey(ns => ns.SubscriptionId);
            modelBuilder.Entity<NewsletterSubscription>()
                .HasIndex(ns => ns.Email)
                .IsUnique();
        }

    }
}
