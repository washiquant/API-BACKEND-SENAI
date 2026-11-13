using EscolaAPI.Contexts;
using EscolaAPI.Interfaces;
using EscolaAPI.Models;

namespace EscolaAPI.Repositories
{
    public class CursoRepository : ICursoRepsitory

    {
        //Responsavel com a conexao com o banco de dados

        //Campo

        //Injetar o contexto da escola no repositorio - uma cozinha precisa de fogo (EscolaContext) para preparar a comida (CursoRepository)
        //Para fazer os pratos; Em vez de criar a classe Context sozinha,
        //ela pede no construtor da API para entregar pronta
        //Isso se chama injeção de dependencia - o contexto ja vem pronto para ser usado.
        private readonly EscolaContext _context;
        //Injeacao de dependencia - construtor - >  A API ENTREGA O EscolaContext ja pronto para ser usado;

        public CursoRepository(EscolaContext context)
        {
            _context = context;
        }
        //INSERT INTO CURSO
        public void Cadastrar(Curso curso)
        {
            _context.Curso.Add(curso);
            _context.SaveChanges();
        }

        public List<Curso> ListarTodos()
        {
            return _context.Curso.ToList();
        }
        public void teste()
        {
            return _context.
        }
           
    }

        
}
