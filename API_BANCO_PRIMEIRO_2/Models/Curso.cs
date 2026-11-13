using System;
using System.Collections.Generic;

namespace API_BANCO_PRIMEIRO_2.Models;

public partial class Curso
{
    public int CodigoCurso { get; set; }

    public string Nome { get; set; } = null!;

    public short CargaHoraria { get; set; }

    public int RegistroProfessor { get; set; }

    public virtual ICollection<Matricula> Matricula { get; set; } = new List<Matricula>();

    public virtual Professor RegistroProfessorNavigation { get; set; } = null!;
}
