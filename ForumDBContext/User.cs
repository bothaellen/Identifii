using Microsoft.AspNetCore.Identity;

namespace Identifii.ForumDBContext
{
    public class User : IdentityUser<Guid>
    {      
      
     
        public UserType UserType { get; set; }
        public DateTime CreatedAt { get; set; }


        // Navigation properties
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Moderation> Moderations { get; set; }
    }
}
