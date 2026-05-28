using System;
using System.Collections.Generic;

namespace PC12410003323100833.CORE.Models;

public partial class OrdenServicio
{
    public int Id { get; set; }

    public DateOnly FechaIngreso { get; set; }

    public string DescripcionProblema { get; set; } = null!;

    public int CostoEstimado { get; set; }

    public string Estado { get; set; } = null!;

    public int? VehiculoId { get; set; }

    public int? TipoServicioId { get; set; }

    public virtual TipoServicio? TipoServicio { get; set; }

    public virtual Vehiculo? Vehiculo { get; set; }
}
