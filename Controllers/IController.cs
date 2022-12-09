using api_base.Data.Dtos;
using api_base.Models;
using api_base.Utils;
using Microsoft.AspNetCore.Mvc;

namespace api_base.Controllers
{
    public interface IController<E, D, I, U, R>
    where E : Entity
    where D : Dto<E>
    where I : InsertDto<E>
    where U : UpdateDto<E>
    where R : Response<E, D>
    {
        public Task<ActionResult<R>> Get(int id);
        public Task<ActionResult<R>> Get();
        public Task<ActionResult<R>> Insert([FromBody] I dto);
        public Task<ActionResult<R>> Update([FromBody] U dto);
        public Task<ActionResult<R>> Delete(int id);
    }
}