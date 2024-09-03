using Identifii.Services;
using Identifii.Models.Request;

namespace Identifii.WebApi.Endpoints
{
    public static class PostsEndpoints
    {
        public static void RegisterPostsEndpoints(this WebApplication application)
        {
            application.MapGet("/posts", async (IPostService service) => await service.GetPostsAsync());

            application.MapGet("/posts/user/{userId}", async (IPostService service, string userId) => await service.GetPostsForUserAsync(userId));
            application.MapGet("/posts/{postId}", async (IPostService service, string postId) => await service.GetPostById(postId));

            application.MapPost("/posts", async (IPostService service, PostRequest postRequest) =>
            {
                var post = await service.CreatePostAsync(postRequest);
                return Results.Created($"posts/{post.PostID}", post);

            });

        }
    }
}
