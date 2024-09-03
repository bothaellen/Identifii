namespace Identifii.ForumDBContext
{
    public class Post
    {
        public int PostID { get; set; }
        public Guid UserID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int LikeCount { get; set; }  // Cached value
        public bool IsTaggedMisleading { get; set; }

        // Navigation properties
        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
        public ICollection<Moderation> Moderations { get; set; }
    }
}
