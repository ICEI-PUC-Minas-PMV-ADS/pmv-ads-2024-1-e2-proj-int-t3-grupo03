﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kippa.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Email { get; set; }

    public string? Nome { get; set; }
    [Required(ErrorMessage = "Obrigatório informar a senha")]
    [DataType(DataType.Password)]
    public string? Senha { get; set; }

    public DateTime? DataNascimento { get; set; }

    public string? Profissao { get; set; }

    public string? Objetivo { get; set; }

    public DateTime? DataCadastro { get; set; }

    public virtual ICollection<Lembrete> Lembretes { get; set; } = new List<Lembrete>();

    public virtual ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();

    public Perfil Perfil { get; set; }


}

public enum Perfil
{
    Admin,
    user
}
