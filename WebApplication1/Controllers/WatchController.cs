using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface.Service;
using Newtonsoft.Json;
using WebApplication1.Model;
using WebApplication1.Interface.Model;
using WebApplication1.Model.Enum;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class WatchController : Controller
    {
        private readonly  IWatchService<IMovieShow> _watchService;

        public WatchController(IWatchService<IMovieShow> watchService)
        {
            _watchService = watchService;
        }

        [Route($"/{enumEntity}")]
        [HttpGet]     
        public async Task<IActionResult> GetMovieShowAsync([FromRoute] EntityEnum enumEntity)
        {     
            var result = await _watchService.GetYear(123);
            return Json(result);        
        }


        [HttpGet]
        public IActionResult GetGenre(Genre genre)
        {
            var result = _watchService.GetGenre(genre.Title);
            return Json(result);
        }
    }
}