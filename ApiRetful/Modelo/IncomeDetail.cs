using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRetful.Modelo
{
    public class IncomeDetail
    {
        [Key]
        public int idincome_detail { get; set; }
        public int idincome { get; set; }
        public int idarticle { get; set; }
        public int quantity { get; set; }
        public string income_description { get; set; }
        public string sku_code { get; set; }
        public decimal price { get; set; }
        public string unit_measure { get; set; } 
    }
}
