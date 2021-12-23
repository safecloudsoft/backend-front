using DataAccessLayer.Abstact;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context context = new Context();

        DbSet<T> _object;
        
        public Repository()
        {
            _object = context.Set<T>();
        }

        public int Delete(T p)
        {
            _object.Remove(p);
            return context.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> Filter)
        {
            return _object.FirstOrDefault(Filter);
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> Filter)
        {
            return _object.Where(Filter).ToList();
        }
    }
}
