using JustBlog.Core;
using System.Web.Mvc;
using JustBlog.Models;
using JustBlog.Core.Objects;
namespace JustBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Posts(int p = 1)
        {
            // TODO: read and return posts from repository

            //var posts = _blogRepository.Posts(p - 1, 10);

            //var totalPosts = _blogRepository.TotalPosts();

            //var listViewModel = new ListViewModel
            //{
            //    Posts = posts,
            //    TotalPosts = totalPosts
            //};

            var viewModel = new ListViewModel(_blogRepository, p);

            ViewBag.Title = "Latest Posts";

            return View("List", viewModel);
        }
    }
}