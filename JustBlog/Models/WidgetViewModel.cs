using JustBlog.Core;
using JustBlog.Core.Objects;
using System.Collections.Generic;

namespace JustBlog.Models
{
    public class WidgetViewModel
    {
        public WidgetViewModel(IBlogRepository blogRepository)
        {
            Categories = blogRepository.Categories();
        }

        public IList<Category> Categories { get; private set; }
    }
}