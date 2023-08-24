using Reboot.Repository;
using Reboot.Data;
using Reboot.Models;



namespace Reboot.Business
{
    public class ArticuloFerreteriaBusiness
    {
        private readonly ArticuloFerreteriaRepository _repository;

        public ArticuloFerreteriaBusiness(RebootContext context)
        {
            _repository = new ArticuloFerreteriaRepository(context);
        }


        public int CrearArticulo(ArticuloFerreteria articuloFerreteria)
        {
            var idArticulo = 0;

            idArticulo = _repository.CrearArticulo(articuloFerreteria);


            return idArticulo;
        }

        public List<ArticuloFerreteria> BuscarArticulo(string nombreDelArticulo)
        {
            var articuloFerreteria = _repository.BuscarArticulo(nombreDelArticulo);
            return articuloFerreteria;
        }

        public int BorrarArticulos(ArticuloFerreteria articuloFerreteria)
        {
            var idBorrar = 0;

            idBorrar = _repository.BorrarArticulos(articuloFerreteria);
            return idBorrar;
        }


    }
}
