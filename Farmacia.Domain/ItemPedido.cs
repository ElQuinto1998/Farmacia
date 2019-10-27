using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacia.Domain
{
    public class ItemPedido
    {
        public string codeMedicamento { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

    }
}
