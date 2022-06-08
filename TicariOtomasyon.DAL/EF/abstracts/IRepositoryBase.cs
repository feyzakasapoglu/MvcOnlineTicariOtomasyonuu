using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.DAL.EF.abstracts
{
    public interface IRepositoryBase<T> where T:class ,new()
    {
        int Add(T input);
        int Update(T input);
        int Delete(T input);

        int DeleteById(int id);

        T GetById(int id);
        public IList<T> GetAll(Expression<Func<T, bool>> filter = null);

        public IQueryable<T> GetAllInclude(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] include);

    }
}
