using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repositories
{
    public class CasaRepository : GenericRepository<Casa>, ICasaRepository
    {
        public CasaRepository(CasaContext context) : base(context)
        {

        }
        public Casa GetCasaAllDetails(int id)
        {
            return _table.Where(arg => arg.CasaId == id)
                .FirstOrDefault();
        }

        public List<Casa> GetCasaAllDetails()
        {
            return _table
                .ToList();
        }

        public List<Casa> GetAllWithInclude()
        {
            return _table.Include(x => x.Useri).ToList();
        }

        public List<Casa> GetAllWithJoin()
        {
            var result = _table.Join(_context.Users, x => x.CasaId, y => y.CasaId,
                (x, y) => new { x, y }).Select(obj => obj.x);

            return result.ToList();
        }

    }
}
