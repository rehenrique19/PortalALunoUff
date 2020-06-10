using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PortalUffRepository.Models.Base;

namespace PortalUffRepository.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void AddOrUpdate(BaseModel entity);

        Task<bool> SaveChangesAsync(bool commitTransaction);

        IQueryable<T> GetAllAsQuery(Expression<Func<T, object>> orderby = null, OrderDirection orderDirection = OrderDirection.Asc, params Expression<Func<T, object>>[] includes);

        Task<IEnumerable<T>> GetAllAsListAsync(Expression<Func<T, object>> orderby = null, OrderDirection orderDirection = OrderDirection.Asc, params Expression<Func<T, object>>[] includes);

        Task<T> GetByIdAsync(params object[] keyValues);

        Task<T> GetByIdAsync(object[] keyValues, params Expression<Func<T, object>>[] includes);
    }

    public enum OrderDirection
    {
        Asc = 1,
        Desc = 2
    }
}
