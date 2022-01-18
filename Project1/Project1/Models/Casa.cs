using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Casa
    {
        [Key]
        public int CasaId { get; set; }
        public string Nume { get; set; }
        public Adresa Adresa { get; set; }
        public ICollection<User> Useri { get; set; }
    }
}
