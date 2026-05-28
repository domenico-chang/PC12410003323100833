using System;
using System.Collections.Generic;

namespace PC12410003323100833.CORE.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Paterno { get; set; } = null!;

    public string Materno { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int Telefono { get; set; }

    public virtual ICollection<Vehiculo> Vehiculo { get; set; } = new List<Vehiculo>();
}
