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
    public class PositionsController : ControllerBase
    {
        private readonly IPositionService _positionService;

        public PositionsController(IPositionService positionService)
        {
            _positionService = positionService;
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _positionService.GetByIdAsync(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }


        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _positionService.GetAllAsync();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }


        [HttpPost("add")]
        public async Task<IActionResult> Add(Position position)
        {
            var result = await _positionService.AddAsync(position);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);            
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(Position position)
        {
            var result = await _positionService.UpdateAsync(position);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Position position)
        {
            var result = await _positionService.DeleteAsync(position);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }
    }
}
