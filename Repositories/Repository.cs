using api_base.Data;
using api_base.Models;
using Microsoft.EntityFrameworkCore;

namespace api_base.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly Context db;

        public Repository(Context db)
        {
            this.db = db;
        }

        public virtual void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
        }

        public virtual void Delete(IEnumerable<T> entities)
        {
            db.Set<T>().RemoveRange(entities);
        }

        public virtual async Task<bool> ExistsAsync(int id)
        {
            return await db.Set<T>().AsNoTracking().AnyAsync(t => t.Id == id);
        }

        public virtual async Task<T?> GetAsync(int id)
        {
            return await db.Set<T>().AsNoTracking().Where(t => t.Id == id).SingleOrDefaultAsync();
        }

        public virtual async Task<T[]> GetAsync()
        {
            return await db.Set<T>().AsNoTracking().ToArrayAsync();
        }

        public virtual async Task InsertAsync(T entity)
        {
            await db.Set<T>().AddAsync(entity);
        }

        public virtual async Task InsertAsync(IEnumerable<T> entities)
        {
            await db.Set<T>().AddRangeAsync(entities);
        }

        public virtual async Task SaveChangesAsync()
        {
            await db.SaveChangesAsync();
        }

        public virtual void Update(T entity)
        {
            db.Set<T>().Update(entity);
        }

        public virtual void Update(IEnumerable<T> entities)
        {
            db.Set<T>().UpdateRange(entities);
        }
    }
}