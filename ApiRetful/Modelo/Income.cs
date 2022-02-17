using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRetful.Modelo
{
    public class Income
    {
        [Key]
        public int idincome { get; set; }
        public int idsupplier { get; set; }
        public int iduser { get; set; }
        public string invoice_number { get; set; }
        public DateTime registration_date { get; set; }
        public decimal tax { get; set; }
        public decimal total { get; set; }
        public string income_statement { get; set; }
    }
}
