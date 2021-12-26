using Microsoft.AspNetCore.Mvc;
using car_simulator_api.Models;
using car_simulator_api.Services;

namespace car_simulator_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        [HttpGet("getAllPlayers")]
        public IActionResult GetAllPlayers() => Ok(PlayerService.GetAllPlayers());

        [HttpGet("getAPlayer")]
        public IActionResult GetAPlayer(Guid id) => Ok(PlayerService.GetAPlayer(id));

        [HttpPost("AddPlayer")]
        public IActionResult AddPlayer(PlayerModel player) => Ok(PlayerService.InsertPlayer(player));
    }
}
