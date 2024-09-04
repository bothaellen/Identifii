using Identifii.ForumDBContext;
using Identifii.Models.Request;
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

        public async Task<Comment> CreateComment(CommentRequest commentRequest)
        {
            var comment = new Comment()
            {
                Content = commentRequest.Content,
                PostID = commentRequest.PostID,
                UserID = commentRequest.UserID
            };
            await _context.Comments.AddAsync(comment);

            await _context.SaveChangesAsync();

            return comment;
        }
    }
}
