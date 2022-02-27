using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult CommentAllByBLog(string blogId)
        {
            var value = _commentService.GetAllByBlogId(blogId);
            return PartialView(value);
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
    }
}
