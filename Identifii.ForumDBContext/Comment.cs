namespace Identifii.ForumDBContext
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int PostID { get; set; }
        public string UserID { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
