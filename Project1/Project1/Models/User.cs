using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CasaId { get; set; }
        public Casa Casa { get; set; }
        public ICollection <UserRol> UserRoles { get; set; }
    }
}
