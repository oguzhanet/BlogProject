using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
