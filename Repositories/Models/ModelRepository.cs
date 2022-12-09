using api_base.Data;
using api_base.Models;

namespace api_base.Repositories.Models
{
    public class ModelRepository : Repository<Model>, IModelRepository
    {
        public ModelRepository(Context db) : base(db) { }
    }
}