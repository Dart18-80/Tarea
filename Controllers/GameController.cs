using Microsoft.AspNetCore.Mvc;
using chessAPI.business.interfaces;
//using chessAPI.models.player;
using chessAPI.models.game;
using Microsoft.AspNetCore.Authorization;


namespace chessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameBusiness<int> bs;

        public GameController(IGameBusiness<int> bs)
        {
            this.bs = bs;
        }

        [HttpPost]
        [Produces("application/json")]
        [Route("PostGame")]
        [AllowAnonymous]
        public async Task<IActionResult> postGame(clsNewGame newGame)
        {
            var result = Results.Ok(await bs.addGame(newGame));
            return Ok(result);
        }
        
        
    }
}