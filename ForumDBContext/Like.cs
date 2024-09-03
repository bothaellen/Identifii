using Microsoft.EntityFrameworkCore;

namespace Identifii.ForumDBContext
{
    public class Like
    {
        public int LikeID { get; set; }
        public int PostID { get; set; }
        public Guid UserID { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public Post Post { get; set; }
        public User User { get; set; }

        // Configure unique constraint via Fluent API
        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Like>()
                .HasIndex(l => new { l.UserID, l.PostID })
                .IsUnique();
        }
    }
}
