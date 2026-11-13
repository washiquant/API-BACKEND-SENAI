using System;
using System.Collections.Generic;

namespace API_BANCO_PRIMEIRO_2.Models;

public partial class Aluno
{
    public int Matricula { get; set; }

    public string Nome { get; set; } = null!;

    public DateOnly DataNascimento { get; set; }

    public string Email { get; set; } = null!;
}
