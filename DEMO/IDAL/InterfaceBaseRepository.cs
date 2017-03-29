using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface InterfaceBaseRepository<T>
    {
        T Add(T entity);
        int Count(Expression<Func<T, bool>> predicate);
        bool Update(T entity);
        bool Delete(T entity);
        bool Exist(Expression<Func<T, bool>> anyLambda);
        T Find(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> FindList<S>(Expression<Func<T, bool>> whereLambda, bool isAcs, Expression<Func<T, S>> orderLambda);
        IQueryable<T> FindPageList<S>(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderLambda);
    }
}
