using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRetful.Modelo
{
    public class Sale
    {
        [Key]
        public int idsale { get; set; }
        public int idclient { get; set; }
        public int iduser { get; set; }
        public string invoice_series { get; set; }
        public string invoice_number { get; set; }
        public DateTime date_hour { get; set; }
        public decimal tax { get; set; }
        public decimal total { get; set; }
        public string status_sale { get; set; }

    }
}
