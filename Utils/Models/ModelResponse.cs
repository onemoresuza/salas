using api_base.Data.Dtos.Models;
using api_base.Models;

namespace api_base.Utils.Models
{
    public class ModelResponse : Response<Model, ModelDto>
    {
        public ModelResponse(StatusCode code, string message, ModelDto dto) : base(code, message, dto) { }
    }
}