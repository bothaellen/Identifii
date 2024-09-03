using Identifii.ForumDBContext;
using Identifii.Models.Request;

namespace Identifii.Services
{
    public interface IPostService
    {
        Task<Post> PostByIdAsync(int id);
        Task<List<Post>> GetPostsAsync();
        Task<List<Post>> GetPostsForUserAsync(string userId);
        Task<Post> CreatePostAsync(PostRequest post);
        Task<Post> GetPostById(string postId);
    }
}
