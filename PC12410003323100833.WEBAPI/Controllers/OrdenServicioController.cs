using Microsoft.AspNetCore.Mvc;
using PC12410003323100833.CORE.Core.DTOs;
using PC12410003323100833.CORE.Core.Interfaces;

namespace PC12410003323100833.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenServicioController : ControllerBase
    {
        private readonly IOrdenServicioService _ordenServicioService;

        public OrdenServicioController(IOrdenServicioService ordenServicioService)
        {
            _ordenServicioService = ordenServicioService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrdenesServicio()
        {
            var ordenes = await _ordenServicioService.GetOrdenesServicio();
            return Ok(ordenes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrdenServicioById(int id)
        {
            var orden = await _ordenServicioService.GetOrdenServicioById(id);

            if (orden == null)
            {
                return NotFound();
            }

            return Ok(orden);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrdenServicio([FromBody] OrdenServicioCreateDTO ordenServicioCreateDTO)
        {
            if (ordenServicioCreateDTO == null)
            {
                return BadRequest();
            }

            await _ordenServicioService.CreateOrdenServicio(ordenServicioCreateDTO);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrdenServicio([FromBody] OrdenServicioUpdateDTO ordenServicioUpdateDTO)
        {
            if (ordenServicioUpdateDTO == null)
            {
                return BadRequest();
            }

            var existingOrden = await _ordenServicioService.GetOrdenServicioById(ordenServicioUpdateDTO.Id);

            if (existingOrden == null)
            {
                return NotFound();
            }

            await _ordenServicioService.UpdateOrdenServicio(ordenServicioUpdateDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrdenServicio(int id)
        {
            var existingOrden = await _ordenServicioService.GetOrdenServicioById(id);

            if (existingOrden == null)
            {
                return NotFound();
            }

            await _ordenServicioService.DeleteOrdenServicio(id);
            return NoContent();
        }
    }
}