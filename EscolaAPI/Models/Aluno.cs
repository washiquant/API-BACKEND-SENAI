using System;
using System.Collections.Generic;

namespace EscolaAPI.Models;

public partial class Aluno
{
    public int Matricula { get; set; }

    public string Nome { get; set; } = null!;

    public DateOnly DataNascimento { get; set; }

    public string Email { get; set; } = null!;
}
