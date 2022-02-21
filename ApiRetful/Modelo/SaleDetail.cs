using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRetful.Modelo
{
    public class SaleDetail
    {
        public int idsale_detail { get; set; }
        public int idsale { get; set; }
        public int idarticle { get; set;  }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public decimal discount { get; set; }
     }
}
