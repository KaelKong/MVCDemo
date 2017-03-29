using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DAL
{
    public class BaseRepository<T> : InterfaceBaseRepository<T> where T : class
    {
        protected MyDbContext mContext = ContextFactory.GetCurrentContext();

        public T Add(T entity)
        {
            mContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Added;
            mContext.SaveChanges();
            return entity;
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return mContext.Set<T>().Count(predicate);
        }

        public bool Delete(T entity)
        {
            mContext.Set<T>().Attach(entity);
            mContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Deleted;
            return mContext.SaveChanges() > 0;
        }

        public bool Exist(Expression<Func<T, bool>> anyLambda)
        {
            return mContext.Set<T>().Any(anyLambda);
        }

        public T Find(Expression<Func<T, bool>> whereLambda)
        {
            T _entiry = mContext.Set<T>().FirstOrDefault<T>(whereLambda);
            return _entiry;
        }

        public IQueryable<T> FindList<S>(Expression<Func<T, bool>> whereLambda, bool isAcs, Expression<Func<T, S>> orderLambda)
        {
            var _list = mContext.Set<T>().Where<T>(whereLambda);
            if (isAcs) _list = _list.OrderBy<T, S>(orderLambda);
            else _list = _list.OrderByDescending<T, S>(orderLambda);
            return _list;
        }

        public IQueryable<T> FindPageList<S>(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLambda, bool isAsc, Expression<Func<T, S>> orderLambda)
        {
            var _list = mContext.Set<T>().Where<T>(whereLambda);
            totalRecord = _list.Count();
            if (isAsc) _list = _list.OrderBy<T, S>(orderLambda);
            else _list = _list.OrderBy<T, S>(orderLambda);

            return _list.Skip<T>(pageSize * (pageSize - 1)).Take<T>(pageSize);
        }

        public bool Update(T entity)
        {
            mContext.Set<T>().Attach(entity);
            mContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
            return mContext.SaveChanges() > 0;
        }
    }
}
