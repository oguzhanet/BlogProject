using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace MvcWebUI.ViewComponents.Component
{
    public class CommentAllByBLog : ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentAllByBLog(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(string id)
        {
            var value = _commentService.GetAllByBlogId(id);
            return View(value);
        }
    }
}
