using System;
using System.Collections.Generic;
using System.Text;

using PC12410003323100833.CORE.Core.DTOs;

namespace PC12410003323100833.CORE.Core.Interfaces
{
    public interface IOrdenServicioService
    {
        Task<IEnumerable<OrdenServicioListDTO>> GetOrdenesServicio();
        Task<OrdenServicioListDTO> GetOrdenServicioById(int id);
        Task CreateOrdenServicio(OrdenServicioCreateDTO ordenServicioCreateDTO);
        Task UpdateOrdenServicio(OrdenServicioUpdateDTO ordenServicioUpdateDTO);
        Task DeleteOrdenServicio(int id);
    }
}