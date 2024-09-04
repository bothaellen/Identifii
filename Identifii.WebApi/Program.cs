using Identifii.ForumDBContext;
using Identifii.Services;
using Identifii.WebApi.Endpoints;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        var connectionString = builder.Configuration.GetConnectionString("ForumDB") ?? throw new InvalidOperationException("Connection string 'ForumDB' not found.");
        builder.Services.AddDbContext<ForumContext>(options =>
            options.UseSqlServer(connectionString)
            .EnableSensitiveDataLogging()
            .LogTo(Console.WriteLine, LogLevel.Information));

        builder.Services.AddScoped<ICommentService, CommentService>();
        builder.Services.AddScoped<IPostService, PostService>();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.RegisterCommentsEndpoints();
        app.RegisterPostsEndpoints();

        app.Run();
    }
}