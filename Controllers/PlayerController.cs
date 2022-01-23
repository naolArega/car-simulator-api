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
        public IActionResult GetAllPlayers()
        {
            try
            {
                return Ok(PlayerService.GetAllPlayers());
            }
            catch
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "Error getting players!");
            }
        }

        [HttpGet("getAPlayer")]
        public IActionResult GetAPlayer(Guid id)
        {
            try
            {
                return Ok(PlayerService.GetAPlayer(id));
            }
            catch
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "Error getting a player!");
            }
        }

        [HttpPost("AddPlayer")]
        public IActionResult AddPlayer(PlayerModel player) 
        {
            try
            {
                return Ok(PlayerService.InsertPlayer(player)); 
            }
            catch
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "Error adding a player!");
            }
        }

        [HttpPut("UpdatePlayer")]
        public IActionResult UpdatePlayer(PlayerModel player)
        {
            try
            {
                return Ok(PlayerService.UpdatePlayer(player));
            }
            catch
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "Error updating a player!");
            }
        }

        [HttpDelete("DeletePlayer")]
        public IActionResult DeletePlayer(Guid id)
        {
            try
            {
                return Ok(PlayerService.DeletePlayer(id));
            }
            catch
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError,
                    "Error deleting a player!");
            }
        }
    }
}
