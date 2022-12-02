using api_base.Data.Dtos.Models;
using api_base.Models;
using api_base.Repositories;

namespace api_base.Services
{
    public class ModelService : Service<Model, ModelDto, ModelInsertDto, ModelUpdateDto>, IModelService
    {
        public ModelService(IModelRepository repository) : base(repository)
        {
        }
    }
}