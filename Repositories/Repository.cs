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

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
        }

        public void Delete(IEnumerable<T> entities)
        {
            db.Set<T>().RemoveRange(entities);
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await db.Set<T>().AsNoTracking().AnyAsync(t => t.Id == id);
        }

        public async Task<T?> GetAsync(int id)
        {
            return await db.Set<T>().AsNoTracking().Where(t => t.Id == id).SingleOrDefaultAsync();
        }

        public async Task<T[]> GetAsync()
        {
            return await db.Set<T>().AsNoTracking().ToArrayAsync();
        }

        public async Task InsertAsync(T entity)
        {
            await db.Set<T>().AddAsync(entity);
        }

        public async Task InsertAsync(IEnumerable<T> entities)
        {
            await db.Set<T>().AddRangeAsync(entities);
        }

        public async Task SaveChangesAsync()
        {
            await db.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
        }

        public void Update(IEnumerable<T> entities)
        {
            db.Set<T>().UpdateRange(entities);
        }
    }
}