using api_base.Data.Dtos;
using api_base.Models;
using api_base.Services;
using api_base.Utils;

namespace api_base.Handlers
{
    public class UpdateHandler<E, D, I, U, R>
    where E : Entity
    where D : Dto<E>
    where I : InsertDto<E>
    where U : UpdateDto<E>
    where R : Response<E, D>
    {
        private readonly IService<E, D, I, U> service;

        public UpdateHandler(IService<E, D, I, U> service)
        {
            this.service = service;
        }

        public virtual async Task<Response<E, D>> HandleAsync(U dto)
        {
            var exists = await service.ExistsAsync(dto.Id);

            if (!exists)
                return Response<E, D>.NotFound();

            service.Update(dto);
            await service.SaveChangesAsync();

            return Response<E, D>.Success(ResponseMessage.Updated);
        }
    }
}