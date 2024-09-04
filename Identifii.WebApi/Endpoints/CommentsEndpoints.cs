using Identifii.ForumDBContext;
using Identifii.Models.Request;
using Identifii.Services;
using Microsoft.EntityFrameworkCore;

namespace Identifii.WebApi.Endpoints
{
    public static class CommentsEndpoints
    {
        public static void RegisterCommentsEndpoints(this WebApplication application)
        {

            application.MapGet("/comments", async (ICommentService service) =>
            {
                var comments = await service.GetCommentsAsync();

                return Results.Ok(comments);

            });          

            application.MapGet("/comments/{id}", async (ICommentService service , int id) => 
            {
                var comment = await service.GetCommentByIdAsync(id);

                return comment is not null ? Results.Ok(comment) : Results.NotFound();
            });

            application.MapPost("/comments", async (ICommentService service, CommentRequest commentRequest) =>
            {
               
                var comment = await service.CreateComment(commentRequest);

                return Results.Created($"/comments/{comment.CommentID}", comment);
            });

        }
    }
}
