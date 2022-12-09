using api_base.Data.Dtos.Models;
using api_base.Models;
using api_base.Repositories.Models;

namespace api_base.Services.Models
{
    public class ModelService : Service<Model, ModelDto, ModelInsertDto, ModelUpdateDto>, IModelService
    {
        public ModelService(IModelRepository repository) : base(repository) { }
    }
}