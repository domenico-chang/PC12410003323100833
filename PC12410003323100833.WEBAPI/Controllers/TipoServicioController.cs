using Microsoft.AspNetCore.Mvc;
using PC12410003323100833.CORE.Core.DTOs;
using PC12410003323100833.CORE.Core.Interfaces;

namespace PC12410003323100833.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoServicioController : ControllerBase
    {
        private readonly ITipoServicioService _tipoServicioService;

        public TipoServicioController(ITipoServicioService tipoServicioService)
        {
            _tipoServicioService = tipoServicioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetTiposServicio()
        {
            var tiposServicio = await _tipoServicioService.GetTiposServicio();
            return Ok(tiposServicio);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipoServicioById(int id)
        {
            var tipoServicio = await _tipoServicioService.GetTipoServicioById(id);

            if (tipoServicio == null)
            {
                return NotFound();
            }

            return Ok(tipoServicio);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTipoServicio(
            [FromBody] TipoServicioCreateDTO tipoServicioCreateDTO)
        {
            if (tipoServicioCreateDTO == null)
            {
                return BadRequest();
            }

            await _tipoServicioService.CreateTipoServicio(tipoServicioCreateDTO);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTipoServicio(
            [FromBody] TipoServicioUpdateDTO tipoServicioUpdateDTO)
        {
            if (tipoServicioUpdateDTO == null)
            {
                return BadRequest();
            }

            var existingTipoServicio =
                await _tipoServicioService.GetTipoServicioById(tipoServicioUpdateDTO.Id);

            if (existingTipoServicio == null)
            {
                return NotFound();
            }

            await _tipoServicioService.UpdateTipoServicio(tipoServicioUpdateDTO);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoServicio(
            [FromBody] TipoServicioDeleteDTO tipoServicioDeleteDTO)
        {
            var existingTipoServicio =
                await _tipoServicioService.GetTipoServicioById(tipoServicioDeleteDTO.Id);

            if (existingTipoServicio == null)
            {
                return NotFound();
            }

            await _tipoServicioService.DeleteTipoServicio(tipoServicioDeleteDTO);

            return NoContent();
        }
    }
}