using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<T> : IEntityRepository<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using var context = new BlogContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var context = new BlogContext();
            context.Remove(entity);
            context.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using var context = new BlogContext();
            return context.Set<T>().SingleOrDefault(filter);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using var context = new BlogContext();
            return filter == null
                    ? context.Set<T>().ToList()
                    : context.Set<T>().Where(filter).ToList();
        }

        public void Update(T entity)
        {
            using var context = new BlogContext();
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
