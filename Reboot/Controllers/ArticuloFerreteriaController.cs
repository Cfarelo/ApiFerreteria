using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Reboot.Business;
using Reboot.Data;
using Reboot.Models;

namespace Reboot.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArticuloFerreteriaController : ControllerBase
    {
        

        private readonly ArticuloFerreteriaBusiness _articuloFerreteriaBusiness;
        public ArticuloFerreteriaController(RebootContext context)
        {
            _articuloFerreteriaBusiness = new ArticuloFerreteriaBusiness(context);
        }


        [HttpPost(Name ="CrearArticulo")]
        public IActionResult CrearArticulo(ArticuloFerreteria articuloFerreteria)
        {
            var idDelArticulo = _articuloFerreteriaBusiness.CrearArticulo(articuloFerreteria);
            return Ok(idDelArticulo);


        }




        [HttpGet("{texto}")]
        public async Task<ActionResult<List<ArticuloFerreteria>>> BuscarArticulos(string texto)
        {
            var articulosEncontrados = _articuloFerreteriaBusiness.BuscarArticulo(texto);

            return articulosEncontrados;
        }


        [HttpDelete(Name = "BorrarArticulos")]
        public IActionResult BorrarArticulos(ArticuloFerreteria articuloFerreteria)
        {
            // 1 - Obtener clientes
            var articuloABorrar = _articuloFerreteriaBusiness.BorrarArticulos(articuloFerreteria);

            return Ok(articuloABorrar);

        }




    }
}
