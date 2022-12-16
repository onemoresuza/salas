using api_base.Data.Dtos;
using api_base.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_base.Utils.Models
{
    public static class Result<E, D>
    where E : Entity
    where D : Dto<E>
    {
        public static ActionResult ToActionResult<R>(Response<E, D> response)
        {
            return response.Code switch
            {
                StatusCode.Ok => new OkObjectResult(response),
                StatusCode.NoContent => new NoContentResult(),
                StatusCode.BadRequest => new BadRequestObjectResult(response),
                StatusCode.Unauthorized => new UnauthorizedObjectResult(response),
                StatusCode.Forbidden => new ForbidResult(),
                StatusCode.NotFound => new NotFoundObjectResult(response),
                _ => new OkObjectResult(response),
            };
        }
    }
}