using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repositories
{
    public interface IRolRepository : IGenericRepository<Rol>
    {
        Rol GetRoleAllDetails(int id);
        List<Rol> GetRolesAllDetails();
    }
}
