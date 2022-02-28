using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRetful.Modelo
{
    public class Marcaje
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public DateTime DateM { get; set; }
        public string EntryTime { get; set; }
        public string DepartureTime { get; set; } 
    }
}
