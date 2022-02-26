using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            var value = _blogService.GetAll();
            return View(value);
        }

        public IActionResult BlogDetail(string Id)
        {
            return View();
        }
    }
}
