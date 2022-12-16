using api_base.Models;

namespace api_base.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<T?> GetAsync(int id);
        Task<T[]> GetAsync();
        Task InsertAsync(T entity);
        Task InsertAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        Task SaveChangesAsync();
        Task<bool> ExistsAsync(int id);
    }
}