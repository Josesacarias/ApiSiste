using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRetful.Modelo
{
    public class Rol
    {
        [Key]
        public int idrol { get; set; }
        public string rol_name { get; set; }
        public string rol_descripcion { get; set; }
        public bool condition { get; set; }
    }
}
