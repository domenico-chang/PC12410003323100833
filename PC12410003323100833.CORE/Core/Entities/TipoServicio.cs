using System;
using System.Collections.Generic;

namespace PC12410003323100833.CORE.Core.Entities;

public partial class TipoServicio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int PrecioBase { get; set; }

    public virtual ICollection<OrdenServicio> OrdenServicio { get; set; } = new List<OrdenServicio>();
}
