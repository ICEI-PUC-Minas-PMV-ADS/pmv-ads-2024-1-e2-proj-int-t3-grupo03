using System;
using System.Collections.Generic;

namespace Kippa.Models;

public partial class Tarefa
{
    public int IdTarefa { get; set; }

    public int? UsuarioId { get; set; }

    public DateTime? DataTarefa { get; set; }

    public TimeOnly? HoraTarefa { get; set; }

    public string? TipoTarefa { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
