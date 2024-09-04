using Identifii.ForumDBContext;
using Identifii.Models.Request;

namespace Identifii.Services
{
    public interface ICommentService
    {
        Task<Comment> CreateComment(CommentRequest commentRequest);
        Task<Comment> GetCommentByIdAsync(int id);
        Task<List<Comment>> GetCommentsAsync();

       Task<List<Comment>> GetCommentsForPost(int postId);
    }
}
