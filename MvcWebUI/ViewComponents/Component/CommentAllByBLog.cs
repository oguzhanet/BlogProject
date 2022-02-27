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

        public IViewComponentResult Invoke()
        {
            var value = _commentService.GetAllByBlogId("0f8fad5b-d9cb-469f-a165-70867728dun5");
            return View(value);
        }
    }
}
