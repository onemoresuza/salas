using api_base.Data.Dtos;
using api_base.Handlers;
using api_base.Models;
using api_base.Utils;
using Microsoft.AspNetCore.Mvc;

namespace api_base.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class Controller<E, D, I, U, R> : ControllerBase, IController<E, D, I, U, R>
    where E : Entity
    where D : Dto<E>
    where I : InsertDto<E>
    where U : UpdateDto<E>
    where R : Response<E, D>
    {
        private readonly ReadHandler<E, D, I, U, R> readHandler;
        private readonly CreateHandler<E, D, I, U, R> createHandler;
        private readonly DeleteHandler<E, D, I, U, R> deleteHandler;
        private readonly UpdateHandler<E, D, I, U, R> updateHandler;

        public Controller(ReadHandler<E, D, I, U, R> readHandler
        , CreateHandler<E, D, I, U, R> createHandler
        , DeleteHandler<E, D, I, U, R> deleteHandler
        , UpdateHandler<E, D, I, U, R> updateHandler)
        {
            this.readHandler = readHandler;
            this.createHandler = createHandler;
            this.deleteHandler = deleteHandler;
            this.updateHandler = updateHandler;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<R>> Get(int id)
        {
            var response = await readHandler.HandleAsync(id);
            return response == null ? NotFound() : Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult<R>> Get()
        {
            var response = await readHandler.HandleAsync();
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<R>> Insert([FromBody] I dto)
        {
            var response = await createHandler.HandleAsync(dto);
            return Ok(response);
        }

        [HttpPut]
        [ProducesResponseType(204)]
        public async Task<ActionResult<R>> Update([FromBody] U dto)
        {
            var response = await updateHandler.HandleAsync(dto);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        public async Task<ActionResult<R>> Delete(int id)
        {
            var response = await deleteHandler.HandleAsync(id);
            return Ok(response);
        }
    }
}