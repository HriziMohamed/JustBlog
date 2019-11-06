using JustBlog.Core.Objects;
using System.Collections.Generic;
using JustBlog.Core;
namespace JustBlog.Models
{
    public class ListViewModel
    {
        public IList<Post> Posts { get; private set; }
        public int TotalPosts { get; private set; }

        public ListViewModel(IBlogRepository _blogRepository, int p)
        {
            Posts = _blogRepository.Posts(p - 1, 10);
            TotalPosts = _blogRepository.TotalPosts();
        }
    }
}