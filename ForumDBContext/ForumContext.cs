using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identifii.ForumDBContext
{
    public enum UserType
    {
        Regular,
        Moderator
    }
    public enum ModerationTag
    {
        Misleading,
        FalseInformation
    }

    public class ForumContext : IdentityDbContext<User,IdentityRole<Guid>,Guid>
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Moderation> Moderations { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTag> PostTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Like>()
                .HasOne(l => l.User)
                .WithMany(u => u.Likes)
                .HasForeignKey(l => l.UserID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Like>()
                .HasIndex(l => new { l.UserID, l.PostID })
                .IsUnique();

            modelBuilder.Entity<PostTag>()
                .HasKey(pt => new { pt.PostID, pt.TagID });

            
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany( u =>u.Comments)
                .HasForeignKey(c =>c.UserID )
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PostID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Post>()
                .HasOne(p => p.User)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Moderation>()
            .HasOne(m => m.Moderator)
            .WithMany(u => u.Moderations)
            .HasForeignKey(p => p.ModeratorID)
            .OnDelete(DeleteBehavior.Restrict);


        }

        public ForumContext(DbContextOptions<ForumContext> options) : base(options)
        {

        }
    }
}
