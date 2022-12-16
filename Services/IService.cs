using api_base.Data.Dtos;
using api_base.Models;

namespace api_base.Services
{
    public interface IService<E, D, I, U>
    where E : Entity
    where D : Dto<E>
    where I : InsertDto<E>
    where U : UpdateDto<E>
    {
        Task<D?> ReadAsync(int id);
        Task<D[]> ReadAsync();
        Task CreateAsync(I insertDto);
        Task CreateAsync(IEnumerable<I> insertDtos);
        void Update(U updateDto);
        void Update(IEnumerable<U> updateDtos);
        void Delete(D dto);
        void Delete(IEnumerable<D> dtos);
        Task SaveChangesAsync();
        Task<bool> ExistsAsync(int id);
    }
}