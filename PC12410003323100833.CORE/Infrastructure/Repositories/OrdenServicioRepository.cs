using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PC12410003323100833.CORE.Core.Entities;
using PC12410003323100833.CORE.Core.Interfaces;
using PC12410003323100833.CORE.Infrastructure.Data;

namespace PC12410003323100833.CORE.Infrastructure.Repositories
{
    public class OrdenServicioRepository : IOrdenServicioRepository
    {
        private readonly TallerMecanicoContext _context;

        public OrdenServicioRepository(TallerMecanicoContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OrdenServicio>> GetOrdenesServicio()
        {
            return await _context.OrdenServicio.ToListAsync();
        }

        public async Task<OrdenServicio> GetOrdenServicioById(int id)
        {
            return await _context.OrdenServicio
                .Where(o => o.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task CreateOrdenServicio(OrdenServicio ordenServicio)
        {
            _context.OrdenServicio.Add(ordenServicio);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrdenServicio(OrdenServicio ordenServicio)
        {
            var existingOrden = await _context.OrdenServicio
                .Where(o => o.Id == ordenServicio.Id)
                .FirstOrDefaultAsync();

            if (existingOrden != null)
            {
                existingOrden.FechaIngreso = ordenServicio.FechaIngreso;
                existingOrden.DescripcionProblema = ordenServicio.DescripcionProblema;
                existingOrden.CostoEstimado = ordenServicio.CostoEstimado;
                existingOrden.Estado = ordenServicio.Estado;
                existingOrden.VehiculoId = ordenServicio.VehiculoId;
                existingOrden.TipoServicioId = ordenServicio.TipoServicioId;

                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteOrdenServicio(int id)
        {
            var existingOrden = await _context.OrdenServicio
                .Where(o => o.Id == id)
                .FirstOrDefaultAsync();

            if (existingOrden != null)
            {
                _context.OrdenServicio.Remove(existingOrden);
                await _context.SaveChangesAsync();
            }
        }
    }
}