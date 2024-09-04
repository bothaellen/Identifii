namespace Identifii.ForumDBContext
{
    public class Moderation
    {
        public int ModerationID { get; set; }
        public int PostID { get; set; }
        public string ModeratorID { get; set; }
        public ModerationTag Tag { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation properties
        public virtual Post Post { get; set; }
        public virtual User Moderator { get; set; }
    }
}
