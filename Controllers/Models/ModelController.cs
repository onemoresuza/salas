using api_base.Data.Dtos.Models;
using api_base.Handlers.Models;
using api_base.Models;
using api_base.Utils.Models;

namespace api_base.Controllers.Models
{
    public class ModelController : Controller<Model, ModelDto, ModelInsertDto, ModelUpdateDto, ModelResponse>
    {
        public ModelController(
            ModelReadHandler modelReadHandler
            , ModelCreateHandler modelCreateHandler
            , ModelDeleteHandler modelDeleteHandler
            , ModelUpdateHandler modelUpdateHandler) : base(
                modelReadHandler
                , modelCreateHandler
                , modelDeleteHandler
                , modelUpdateHandler)
        { }
    }
}