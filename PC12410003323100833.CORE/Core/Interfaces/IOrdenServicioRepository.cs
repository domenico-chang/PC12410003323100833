using System;
using System.Collections.Generic;
using System.Text;
using PC12410003323100833.CORE.Core.Entities;

namespace PC12410003323100833.CORE.Core.Interfaces
{
    public interface IOrdenServicioRepository
    {
        Task<IEnumerable<OrdenServicio>> GetOrdenesServicio();
        Task<OrdenServicio> GetOrdenServicioById(int id);
        Task CreateOrdenServicio(OrdenServicio ordenServicio);
        Task UpdateOrdenServicio(OrdenServicio ordenServicio);
        Task DeleteOrdenServicio(int id);
    }
}