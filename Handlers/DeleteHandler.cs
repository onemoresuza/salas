using api_base.Data.Dtos;
using api_base.Models;
using api_base.Services;
using api_base.Utils;

namespace api_base.Handlers
{
    public class DeleteHandler<E, D, I, U, R>
    where E : Entity
    where D : Dto<E>
    where I : InsertDto<E>
    where U : UpdateDto<E>
    where R : Response<E, D>
    {
        private readonly IService<E, D, I, U> service;

        public DeleteHandler(IService<E, D, I, U> service)
        {
            this.service = service;
        }

        public virtual async Task<Response<E, D>> HandleAsync(int id)
        {
            var model = await service.ReadAsync(id);

            if (model == default)
                return Response<E, D>.Deleted();

            service.Delete(model);
            await service.SaveChangesAsync();

            return Response<E, D>.Deleted();
        }
    }
}