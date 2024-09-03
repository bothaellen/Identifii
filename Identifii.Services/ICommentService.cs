using Identifii.ForumDBContext;

namespace Identifii.Services
{
    public interface ICommentService
    {
        Task<Comment> GetCommentByIdAsync(int id);
        Task<List<Comment>> GetCommentsAsync();

       Task<List<Comment>> GetCommentsForPost(int postId);
    }
}
