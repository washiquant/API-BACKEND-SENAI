using EscolaAPI.Models;


namespace EscolaAPI.Interfaces
{
    public interface ICursoRepsitory
    {
        //R - read - devolver todos os cursos
        List<Curso> ListarTodos();

        //Create - criar um novo curso
        void Cadastrar(Curso curso);

    }
}
