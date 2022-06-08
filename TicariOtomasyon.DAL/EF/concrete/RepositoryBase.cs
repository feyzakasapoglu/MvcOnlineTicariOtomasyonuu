using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TicariOtomasyon.DAL.EF.abstracts;
using TicariOtomasyon.DAL.EF.Contexts;

namespace TicariOtomasyon.DAL.EF.concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T>
        where T : class, new()
    {
        TicariDbContext db;
        public RepositoryBase()
        {
            db = new TicariDbContext();
        }
        public int Add(T input)
        {
            db.Set<T>().Add(input);
            return db.SaveChanges();
        }

        public int Delete(T input)
        {
            db.Set<T>().Remove(input);
            return db.SaveChanges();
        }

        public int DeleteById(int id)
        {
            var entity = db.Set<T>().Find(id);
             db.Set<T>().Remove(entity);

            return db.SaveChanges();
        }

        public T Find(int id)
        {
            return db.Set<T>().Find(id);
        }

        public IList<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<T>().ToList();
            }
            else
            {
                return db.Set<T>().Where(filter).ToList();
            }
        }

        public IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> query;

            if (filter != null)
                query = db.Set<T>().Where(filter);
            else
                query = db.Set<T>();



            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));

        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public int Update(T input)
        {
            var result = db.Entry<T>(input);
            result.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
