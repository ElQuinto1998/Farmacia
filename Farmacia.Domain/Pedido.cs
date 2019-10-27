using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacia.Domain
{
    public class Pedido
    {
        public string numberPedido { get; set; }
        public List<ItemPedido> items { get; set; }
        public string userEmail { get; set; }
        public string state { get; set; }
        public string total { get; set; }
        public DateTime dateSolicitud { get; set; }
        public DateTime dateAprobacion { get; set; }

    }
}
