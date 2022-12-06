using api_base.Data.Dtos;
using api_base.Models;

namespace api_base.Utils
{
    public class Response<T> where T : Entity
    {
        public StatusCode Code { get; init; }
        public string Message { get; init; }
        public Dto<T>? Dto { get; init; }

        public Response(StatusCode code, string message, Dto<T>? dto = null)
        {
            Code = code;
            Message = message;
            Dto = dto;
        }

        public static Response<T> Success(string? message, Dto<T>? dto = null)
        {
            return new Response<T>(
                StatusCode.Ok
                , message == null ? ResponseMessage.Success : message
                , dto
            );
        }

        public static Response<T> InternalError(string? message, Dto<T>? dto = null)
        {
            return new Response<T>(
                StatusCode.InternalServerError
                , message == null ? ResponseMessage.InternalError : message
                , dto
            );
        }
    }
}