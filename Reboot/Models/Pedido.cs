﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reboot.Models
{
    public class Pedido: MiClaseBase
    {
   
        public DateTime FechaDelPedido { get; set; }
        public int ClienteId { get; set; }

        [NotMapped]
        public List<DetalleDelPedido> DetalleDelPedido { get; set; }

        [NotMapped]
        public Cliente ClienteDelPedido { get; set; }

      
    }
}
