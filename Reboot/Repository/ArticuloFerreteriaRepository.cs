using Reboot.Models;
using Reboot.Data;
 

namespace Reboot.Repository
{
    public class ArticuloFerreteriaRepository
    {
        private readonly RebootContext _context;

        public ArticuloFerreteriaRepository (RebootContext context)
        {
            _context = context;
        }



        public int CrearArticulo(ArticuloFerreteria articuloFerreteria)
        {
            _context.ArticuloFerreteria.Add(articuloFerreteria);
            _context.SaveChanges();
            return articuloFerreteria.Id;
        }

        public List<ArticuloFerreteria> BuscarArticulo(string nombreDelArticulo)
        {
            var articulo = _context.ArticuloFerreteria.Where(x => x.NombreDeArticulo.Contains(nombreDelArticulo)).ToList();
            return articulo;
        }

        public int BorrarArticulos(ArticuloFerreteria articuloFerreteria)
        {
            _context.ArticuloFerreteria.Remove(articuloFerreteria);
            _context.SaveChanges();
            return articuloFerreteria.Id;
        }

    }

}
