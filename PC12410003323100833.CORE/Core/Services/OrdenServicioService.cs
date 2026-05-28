using System;
using System.Collections.Generic;
using System.Text;
using PC12410003323100833.CORE.Core.DTOs;
using PC12410003323100833.CORE.Core.Entities;
using PC12410003323100833.CORE.Core.Interfaces;

namespace PC12410003323100833.CORE.Core.Services
{
    public class OrdenServicioService : IOrdenServicioService
    {
        private readonly IOrdenServicioRepository _ordenServicioRepository;

        public OrdenServicioService(IOrdenServicioRepository ordenServicioRepository)
        {
            _ordenServicioRepository = ordenServicioRepository;
        }

        public async Task<IEnumerable<OrdenServicioListDTO>> GetOrdenesServicio()
        {
            var ordenes = await _ordenServicioRepository.GetOrdenesServicio();
            var ordenesDTO = new List<OrdenServicioListDTO>();

            foreach (var orden in ordenes)
            {
                ordenesDTO.Add(new OrdenServicioListDTO
                {
                    Id = orden.Id,
                    FechaIngreso = orden.FechaIngreso,
                    DescripcionProblema = orden.DescripcionProblema,
                    CostoEstimado = orden.CostoEstimado,
                    Estado = orden.Estado,
                    VehiculoId = orden.VehiculoId,
                    TipoServicioId = orden.TipoServicioId
                });
            }

            return ordenesDTO;
        }

        public async Task<OrdenServicioListDTO> GetOrdenServicioById(int id)
        {
            var orden = await _ordenServicioRepository.GetOrdenServicioById(id);

            if (orden == null)
            {
                return null;
            }

            return new OrdenServicioListDTO
            {
                Id = orden.Id,
                FechaIngreso = orden.FechaIngreso,
                DescripcionProblema = orden.DescripcionProblema,
                CostoEstimado = orden.CostoEstimado,
                Estado = orden.Estado,
                VehiculoId = orden.VehiculoId,
                TipoServicioId = orden.TipoServicioId
            };
        }

        public async Task CreateOrdenServicio(OrdenServicioCreateDTO ordenServicioCreateDTO)
        {
            var orden = new OrdenServicio
            {
                FechaIngreso = ordenServicioCreateDTO.FechaIngreso,
                DescripcionProblema = ordenServicioCreateDTO.DescripcionProblema,
                CostoEstimado = ordenServicioCreateDTO.CostoEstimado,
                Estado = ordenServicioCreateDTO.Estado,
                VehiculoId = ordenServicioCreateDTO.VehiculoId,
                TipoServicioId = ordenServicioCreateDTO.TipoServicioId
            };

            await _ordenServicioRepository.CreateOrdenServicio(orden);
        }

        public async Task UpdateOrdenServicio(OrdenServicioUpdateDTO ordenServicioUpdateDTO)
        {
            var existingOrden = await _ordenServicioRepository.GetOrdenServicioById(ordenServicioUpdateDTO.Id);

            if (existingOrden != null)
            {
                existingOrden.FechaIngreso = ordenServicioUpdateDTO.FechaIngreso;
                existingOrden.DescripcionProblema = ordenServicioUpdateDTO.DescripcionProblema;
                existingOrden.CostoEstimado = ordenServicioUpdateDTO.CostoEstimado;
                existingOrden.Estado = ordenServicioUpdateDTO.Estado;
                existingOrden.VehiculoId = ordenServicioUpdateDTO.VehiculoId;
                existingOrden.TipoServicioId = ordenServicioUpdateDTO.TipoServicioId;

                await _ordenServicioRepository.UpdateOrdenServicio(existingOrden);
            }
        }

        public async Task DeleteOrdenServicio(int id)
        {
            await _ordenServicioRepository.DeleteOrdenServicio(id);
        }
    }
}