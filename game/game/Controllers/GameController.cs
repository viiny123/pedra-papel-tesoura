using game.Models;
using game.Services;
using Microsoft.AspNetCore.Mvc;

namespace game.Controllers
{
    [ApiController]
    [Route("api/game")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }
        
        [HttpPost]
        public IActionResult RunGame([FromBody] Game game)
        {
            var result = _gameService.RunGame(game);
            return Ok(result);
        }
    }
}