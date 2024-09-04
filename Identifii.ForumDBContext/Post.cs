namespace Identifii.ForumDBContext
{
    public class Post
    {
        public int PostID { get; set; }
        public string UserID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int LikeCount { get; set; }  // Cached value
        public bool IsTaggedMisleading { get; set; }

        // Navigation properties
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public  virtual ICollection<PostTag> PostTags { get; set; }
        public virtual ICollection<Moderation> Moderations { get; set; }
    }
}
