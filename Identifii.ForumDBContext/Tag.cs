namespace Identifii.ForumDBContext
{
    public class Tag
    {
        public int TagID { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public ICollection<PostTag> PostTags { get; set; }
    }
}
