
using API_PIZZARIA.Models;
using API_PIZZARIA.Interface;
using API_PIZZARIA.Contexts;
namespace API_PIZZARIA.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly PizzariaContext _context;
        public ClienteRepository(PizzariaContext context)
        {
            _context = context;
        }
        public List<Cliente> ListarClientes()
        {
            return _context.Cliente.ToList();
        }
    }
}
