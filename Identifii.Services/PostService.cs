using Identifii.ForumDBContext;
using Identifii.Models.Request;
using Microsoft.EntityFrameworkCore;

namespace Identifii.Services
{
    public class PostService : IPostService
    {
        private readonly ForumContext _context;

        public PostService(ForumContext context)
        {
            _context = context;
        }

        public async Task<Post> CreatePostAsync(PostRequest post)
        {

            var inserted = new Post() { Title = post.Title, Content = post.Content , UserID  = post.useridentifier  };

           _context.Posts.Add(inserted);

            await _context.SaveChangesAsync();

            return inserted;

        }

        public async Task<Post> GetPostById(string postId)
        {
           return await _context.Posts.FirstOrDefaultAsync(x=>x.PostID == x.PostID);
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<List<Post>> GetPostsForUserAsync(string userId)
        {
            return await _context.Posts.Where(p => p.UserID == userId).ToListAsync();
        }

        public Task<Post> PostByIdAsync(int id)
        {
            return _context.Posts.SingleOrDefaultAsync(p => p.PostID == id);

        }
    }
}
