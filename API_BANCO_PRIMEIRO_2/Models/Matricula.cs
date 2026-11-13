using System;
using System.Collections.Generic;

namespace API_BANCO_PRIMEIRO_2.Models;

public partial class Matricula
{
    public int MatriculaAluno { get; set; }

    public int CodigoCurso { get; set; }

    public DateTime? DataMatricula { get; set; }

    public virtual Curso CodigoCursoNavigation { get; set; } = null!;
}
