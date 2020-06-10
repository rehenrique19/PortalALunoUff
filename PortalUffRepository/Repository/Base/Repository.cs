using Microsoft.EntityFrameworkCore;
using PortalUffRepository.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace PortalUffRepository.Repository.Base
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext context) { _context = context; }

        public void Add(T entity) => _context.Add(entity);

        public void Update(T entity) => _context.Update(entity);

        public void AddOrUpdate(BaseModel entity) { if (entity.Id > 0) { _context.Update(entity); } else { _context.Add(entity); } }

        public void Remove(T entity) => _context.Remove(entity);

        async Task<bool> IRepository<T>.SaveChangesAsync(bool commitTransaction) => commitTransaction ? (await _context.SaveChangesAsync()) > 0 : true;


        public IQueryable<T> GetAllAsQuery(Expression<Func<T, object>> orderby = null, OrderDirection orderDirection = OrderDirection.Asc, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>();

            if (orderby != null)
                query = orderDirection.Equals(OrderDirection.Asc) ? query.OrderBy(orderby) : query.OrderByDescending(orderby);

            if (includes != null)
                foreach (var i in includes) query = query.Include(i);

            return query;
        }


        public async Task<IEnumerable<T>> GetAllAsListAsync(Expression<Func<T, object>> orderby = null, OrderDirection orderDirection = OrderDirection.Asc, params Expression<Func<T, object>>[] includes)
            => await GetAllAsQuery(orderby, orderDirection, includes).ToListAsync();


        public async Task<T> GetByIdAsync(params object[] keyValues) => await _context.Set<T>().FindAsync(keyValues);

        public async Task<T> GetByIdAsync(object[] keyValues, params Expression<Func<T, object>>[] includes)
            => await ((DbSet<T>)GetAllAsQuery(includes: includes)).FindAsync(keyValues, CancellationToken.None);

        protected IQueryable<T> GetAsQuery(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderby = null, OrderDirection orderDirection = OrderDirection.Asc, params Expression<Func<T, object>>[] includes)
            => GetAllAsQuery(orderby, orderDirection, includes).Where(predicate);


        protected async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderby = null, OrderDirection orderDirection = OrderDirection.Asc, params Expression<Func<T, object>>[] includes)
            => await GetAsQuery(predicate, orderby, orderDirection, includes).FirstOrDefaultAsync();

        protected async Task<IEnumerable<T>> GetAsListAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> orderby = null, OrderDirection orderDirection = OrderDirection.Asc, params Expression<Func<T, object>>[] includes)
            => await GetAsQuery(predicate, orderby, orderDirection, includes).ToListAsync();
    }
}