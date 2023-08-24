using NuGet.Protocol.Core.Types;
using Reboot.Data;
using Reboot.Models;

namespace Reboot.Repository
{
    public class ClienteRepository
    {
        private readonly RebootContext _context;

        public ClienteRepository(RebootContext context)
        {
            _context = context;
        }

        public int CrearCliente(Cliente elCLiente)
        {
            _context.Cliente.Add(elCLiente);
       
            _context.SaveChanges();

            return elCLiente.Id;
        }
        public int BorrarCliente(Cliente idCLiente)
        {
            _context.Cliente.Remove(idCLiente);

            _context.SaveChanges();

            return idCLiente.Id;
        }


        public List<Cliente> ObtenerClientes() 
        {
            return _context.Cliente.ToList();
        }

        public List<Cliente> BuscarClientes(string nombreDelCliente)
        {
            // 1 - Obtengo los cliente
            var clientes = _context
                .Cliente
                .Where(x => x.NombreCliente.Contains(nombreDelCliente))
                .ToList();

            // 2 - Retorno los cliente 
            return clientes;
        }
    }
}
