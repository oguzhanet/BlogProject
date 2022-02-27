using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAllByBlogId(string blogId);
        Comment GetById(string id);
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
    }
}
