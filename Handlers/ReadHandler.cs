using api_base.Data.Dtos;
using api_base.Models;
using api_base.Services;
using api_base.Utils;

namespace api_base.Handlers
{
    public class ReadHandler<E, D, I, U, R>
    where E : Entity
    where D : Dto<E>
    where I : InsertDto<E>
    where U : UpdateDto<E>
    where R : Response<E, D>
    {
        private readonly IService<E, D, I, U> service;

        public ReadHandler(IService<E, D, I, U> service)
        {
            this.service = service;
        }

        public virtual async Task<Response<E, D>> HandleAsync(int id)
        {
            var dto = await service.ReadAsync(id);
            if (dto == default)
            {
                return Response<E, D>.NotFound();
            }

            return Response<E, D>.Success(dto: dto);
        }

        public virtual async Task<Response<E, D>> HandleAsync()
        {
            var dtos = await service.ReadAsync();

            if (dtos == default || dtos.Length == 0)
                return Response<E, D>.NoContent();

            return Response<E, D>.Success(dtos: dtos);
        }
    }
}