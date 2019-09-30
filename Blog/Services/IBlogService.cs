using Blog.Models;
using System.Collections.Generic;

namespace Blog.Services
{
    public interface IBlogService
    {
        List<BlogPost> GetLatestPosts();
        string GetPostText(string link);

        List<BlogPost> GetOlderPosts(int oldestPostId);
    }
}