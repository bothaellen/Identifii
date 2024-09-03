namespace Identifii.ForumDBContext
{
    public class PostTag
    {
        public int PostTagID { get; set; }
        public int PostID { get; set; }
        public int TagID { get; set; }

        // Navigation properties
        public virtual Post Post { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
