using api_base.Data.Dtos.Models;
using api_base.Models;
using api_base.Services.Models;
using api_base.Utils.Models;

namespace api_base.Handlers.Models
{
    public class ModelDeleteHandler : DeleteHandler<Model, ModelDto, ModelInsertDto, ModelUpdateDto, ModelResponse>
    {
        public ModelDeleteHandler(IModelService service) : base(service) { }
    }
}