using Project1.Data;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repositories
{
    public class UserRolRepository : GenericRepository<UserRol>, IUserRolRepository
    {
        public UserRolRepository(CasaContext context) : base(context)
        {

        }
    }
}
