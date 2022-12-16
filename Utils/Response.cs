using api_base.Data.Dtos;
using api_base.Models;

namespace api_base.Utils
{
    public class Response<E, D>
    where E : Entity
    where D : Dto<E>
    {
        public StatusCode Code { get; init; }
        public string Message { get; init; }
        public D[]? Result { get; init; }

        public Response(StatusCode code, string message, D dto)
        {
            Code = code;
            Message = message;
            Result = new D[] { dto };
        }

        public Response(StatusCode code, string message, D[]? dtos = null)
        {
            Code = code;
            Message = message;
            Result = dtos ?? Array.Empty<D>();
        }

        public static Response<E, D> Success(string? message = null)
        {
            return new Response<E, D>(StatusCode.NoContent, message ?? ResponseMessage.Success);
        }
        public static Response<E, D> Success(D[] dtos, string? message = null)
        {
            return new Response<E, D>(StatusCode.Ok, message ?? ResponseMessage.Success, dtos);
        }
        public static Response<E, D> Success(D dto, string? message = null)
        {
            return new Response<E, D>(StatusCode.Ok, message ?? ResponseMessage.Success, dto);
        }

        public static Response<E, D> Deleted()
        {
            return new Response<E, D>(StatusCode.NoContent, ResponseMessage.Deleted);
        }

        public static Response<E, D> Created()
        {
            return new Response<E, D>(StatusCode.Created, ResponseMessage.Created);
        }

        public static Response<E, D> InternalError(string? message = null)
        {
            return new Response<E, D>(StatusCode.InternalServerError, message ?? ResponseMessage.InternalServerError);
        }

        public static Response<E, D> NotFound(string? message = null)
        {
            return new Response<E, D>(StatusCode.NotFound, message ?? ResponseMessage.NotFound);
        }

        public static Response<E, D> BadRequest(string? message = null)
        {
            return new Response<E, D>(StatusCode.BadRequest, message ?? ResponseMessage.BadRequest);
        }
    }
}