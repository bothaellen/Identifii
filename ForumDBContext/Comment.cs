namespace Identifii.ForumDBContext
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public Guid UserID { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public Post Post { get; set; }
        public User User { get; set; }
    }
}
