using Project1.Data;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repositories
{
    public class RoleRepository : GenericRepository<Rol>, IRolRepository
    {
        public RoleRepository(CasaContext context) : base(context)
        {
        }

        public Rol GetRoleAllDetails(int id)
        {
            return _table.Where(arg => arg.RoleId == id)
                .FirstOrDefault();
        }

        public List<Rol> GetRolesAllDetails()
        {
            return _table
                .ToList();
        }
    }
}
