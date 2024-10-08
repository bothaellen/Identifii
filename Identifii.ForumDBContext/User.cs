﻿using Microsoft.AspNetCore.Identity;

namespace Identifii.ForumDBContext
{
    public class User : IdentityUser
    {
        public override string Id { get; set; } = Guid.NewGuid().ToString();
        public UserType UserType { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }    


        // Navigation properties
        public virtual ICollection<Post>? Posts { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
        public virtual ICollection<Like>? Likes { get; set; }
        public virtual ICollection<Moderation>? Moderations { get; set; }
    }
}
