using GameStore.WebAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameStoreContext _context;
        public GameController(GameStoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Games);
        }
        [HttpGet("GetOutro")]
        public string GetOutro()
        {
            return "Olá novamente";
        }
    }
}