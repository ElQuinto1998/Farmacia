using System;
using System.Collections.Generic;
using System.Text;

namespace Farmacia.Domain
{
   public class Medicamento
    {
        public string code { get; set; }
        public string name { get; set; }
        public int salePrice { get; set; }
        public string image { get; set; }
        public bool selected { get; set; }
    }
}
