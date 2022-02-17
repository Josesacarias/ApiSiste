using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRetful.Modelo
{
    public class Person
    {
        [Key]
        public int idperson { get; set; }
        public string type_person { get; set; }
        public string first_name { get; set; }
        public string second_name { get; set; }
        public string first_surname { get; set; }
        public string second_surname { get; set; }
        public string dpi { get; set; }
        public string document_type { get; set; }
        public string address_person { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

    }
}
