using Microsoft.AspNetCore.Mvc;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using chessAPI;
using chessAPI.business.interfaces;
using chessAPI.models.player;
using Microsoft.AspNetCore.Authorization;
using Serilog;
using Serilog.Events;

namespace chessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        [HttpPost]
        [Produces("application/json")]
        [Route("postPlayer")]
        [AllowAnonymous]
        public async Task<IActionResult> postPlayer(IPlayerBusiness<int> bs,clsNewPlayer newPlayer)
        {
            var x = Results.Ok(await bs.addPlayer(newPlayer));
            return Ok(x);
        }
    }
}
