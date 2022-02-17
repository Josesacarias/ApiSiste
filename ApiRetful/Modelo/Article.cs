using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRetful.Modelo
{
    public class Article
    {
        [Key]
        public int idarticle { get; set; }
        public int idcategory { get; set; }
        public string bar_code { get; set; }
        public string sku_code { get; set; }
        public string product_name { get; set; }
        public string supplier_code { get; set; }
        public string supplier { get; set; }
        public string product_description { get; set; }
        public decimal purchase_price { get; set; }
        public string unit_measure { get; set; }
        public decimal tax { get; set; }
        public decimal sale_price { get; set; }
        public string classification_product { get; set; }
        public string invoice_number { get; set; }
        public int maximum_product { get; set; }
        public DateTime registration_date { get; set; }
        public bool condicion { get; set; }
    }
}
