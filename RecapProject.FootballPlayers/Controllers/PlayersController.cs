using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecapProject.FootballPlayers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _playerService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _playerService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(Player player)
        {
            var result = await _playerService.AddAsync(player);
            if (result.Success)
            {
                return Created("", player);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(Player player)
        {
            var result = await _playerService.UpdateAsync(player);
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Player player)
        {
            var result = await _playerService.DeleteAsync(player);
            if (result.Success)
            {
                return NoContent();
            }
            return BadRequest(result.Message);
        }
    }
}
