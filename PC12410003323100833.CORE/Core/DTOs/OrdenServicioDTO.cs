using System;
using System.Collections.Generic;
using System.Text;

namespace PC12410003323100833.CORE.Core.DTOs
{
    public class OrdenServicioDTO
    {
        public int Id { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public string DescripcionProblema { get; set; }
        public int CostoEstimado { get; set; }
        public string Estado { get; set; }
        public int? VehiculoId { get; set; }
        public int? TipoServicioId { get; set; }
    }

    public class OrdenServicioListDTO
    {
        public int Id { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public string DescripcionProblema { get; set; }
        public int CostoEstimado { get; set; }
        public string Estado { get; set; }
        public int? VehiculoId { get; set; }
        public int? TipoServicioId { get; set; }
    }

    public class OrdenServicioCreateDTO
    {
        public DateOnly FechaIngreso { get; set; }
        public string DescripcionProblema { get; set; }
        public int CostoEstimado { get; set; }
        public string Estado { get; set; }
        public int? VehiculoId { get; set; }
        public int? TipoServicioId { get; set; }
    }

    public class OrdenServicioUpdateDTO
    {
        public int Id { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public string DescripcionProblema { get; set; }
        public int CostoEstimado { get; set; }
        public string Estado { get; set; }
        public int? VehiculoId { get; set; }
        public int? TipoServicioId { get; set; }
    }
}