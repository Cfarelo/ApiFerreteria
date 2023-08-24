using System.ComponentModel.DataAnnotations;

namespace Reboot.Models
{
    public class ArticuloFerreteria : MiClaseBase
    {
        //public ArticuloFerreteria(ArticuloFerreteria articuloFerreteria, string nombreDeArticulo, int precioVenta, int precioCosto)
        //{
        //    NombreDeArticulo = nombreDeArticulo;
        //    PrecioVenta = precioVenta;
        //    PrecioCosto = precioCosto;
        //}

        public string? NombreDeArticulo { get; set; }

       

        public int? PrecioVenta { get; set; }
        public int? PrecioCosto { get; set; }
       
        //public ArticuloFerreteria ArticuloFerreteria { get; }
        //public object PrecioVenta1 { get; }
        //public object PrecioCosto1 { get; }
    }
}
