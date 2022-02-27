using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Conrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            comment.CommentId = "ogzhn/" + Guid.NewGuid();
            _commentDal.Add(comment);
        }

        public void Delete(Comment comment)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAllByBlogId(string blogId)
        {
            return _commentDal.GetAll(x => x.BlogId == blogId);
        }

        public Comment GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
