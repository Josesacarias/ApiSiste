using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRetful.Modelo
{
    public class Category
    {
        [Key]
        public int idcategory { get; set; }
        public string name { get; set; }
        public string description_category { get; set; }
        public DateTime registration_date { get; set; }
        public bool condition { get; set; }


    }
}
