using Identifii.ForumDBContext;
using Microsoft.EntityFrameworkCore;

namespace Identifii.Services
{
    public class CommentService : ICommentService
    {
        private readonly ForumContext _context;

        public CommentService(ForumContext context)
        {
            _context = context;
        }
        public async Task<List<Comment>> GetCommentsAsync()
        {
            return await _context.Comments.ToListAsync();
        }
        
        public async Task<Comment> GetCommentByIdAsync(int id)
        {
            return await _context.Comments.FirstOrDefaultAsync(c => c.CommentID == id);
        }

        public async Task<List<Comment>> GetCommentsForPost(int postId)
        {
            return await _context.Comments.Where(c => c.PostID == postId).ToListAsync();           
        }
    }
}
