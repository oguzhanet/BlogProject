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
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAllWithCategory();
        }

        public Blog GetById(string id)
        {
            return _blogDal.Get(x=>x.BlogId == id);
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
