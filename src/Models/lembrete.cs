using System;
using System.Collections.Generic;

namespace Kippa.Models;

public partial class Lembrete
{
    public int IdLembrete { get; set; }

    public int? UsuarioId { get; set; }

    public string? NomeLembrete { get; set; }

    public DateTime? DataLembrete { get; set; }

    public TimeOnly? HoraLembrete { get; set; }

    public int? Notificacoes { get; set; }

    public virtual Usuario? Usuario { get; set; }

    public string Categoria { get; set; }
}