using api_base.Data.Dtos.Models;
using api_base.Models;
using api_base.Services;
using api_base.Services.Models;
using api_base.Utils.Models;

namespace api_base.Handlers.Models
{
    public class ModelCreateHandler : CreateHandler<Model, ModelDto, ModelInsertDto, ModelUpdateDto, ModelResponse>
    {
        public ModelCreateHandler(IModelService service) : base(service){}
    }
}