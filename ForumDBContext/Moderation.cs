namespace Identifii.ForumDBContext
{
    public class Moderation
    {
        public int ModerationID { get; set; }
        public int PostID { get; set; }
        public Guid ModeratorID { get; set; }
        public ModerationTag Tag { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public Post Post { get; set; }
        public User Moderator { get; set; }
    }
}
