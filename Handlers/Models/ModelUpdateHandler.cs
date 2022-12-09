using api_base.Data.Dtos.Models;
using api_base.Models;
using api_base.Services.Models;
using api_base.Utils.Models;

namespace api_base.Handlers.Models
{
    public class ModelUpdateHandler : UpdateHandler<Model, ModelDto, ModelInsertDto, ModelUpdateDto, ModelResponse>
    {
        public ModelUpdateHandler(IModelService service) : base(service) { }
    }
}