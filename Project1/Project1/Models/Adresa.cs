using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Adresa
    {
        [Key]
        public int AdresaId { get; set; }
        public int CasaId { get; set; }
        public Casa Casa { get; set; }
        public string AdresaName { get; set; }
    }
}
