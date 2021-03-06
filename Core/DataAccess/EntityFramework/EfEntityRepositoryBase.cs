using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBasez<T, TContext> : IEntityRepository<T> where T : class, IEntity, new() where TContext : DbContext, new()
    {
        public async Task AddAsync(T entity)
        {
            using var context = new TContext();
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            using var context = new TContext();
            await Task.Run(() => { context.Set<T>().Remove(entity); });
            await context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            using var context = new TContext();
            return predicate == null ? await context.Set<T>().ToListAsync() : await context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            using var context = new TContext();
            return await context.Set<T>().FindAsync(predicate);
        }

        public async Task UpdateAsync(T entity)
        {
            using var context = new TContext();
            await Task.Run(() => { context.Set<T>().Update(entity); });
            await context.SaveChangesAsync();
        }
    }
}
