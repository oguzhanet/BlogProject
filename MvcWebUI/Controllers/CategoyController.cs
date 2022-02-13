using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class CategoyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
