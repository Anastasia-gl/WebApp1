using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface.Service;
using Newtonsoft.Json;
using WebApplication1.Model;
using WebApplication1.Interface.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntityController<T>: Controller
    {
        private readonly IEntityService<T> _entityService;

        public EntityController(IEntityService<T> entityService)
        {
            _entityService = entityService;
        }

        [HttpGet(Name = "EntityByLastName")]
        public IActionResult GetMovie(IActorProducer actorProducer)
        {
            var result = _entityService.GetLastName(actorProducer.LastName);
            return Json(result);
        }

    }
}
