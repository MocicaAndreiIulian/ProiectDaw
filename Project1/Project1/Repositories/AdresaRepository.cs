using Project1.Data;
using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repositories
{
    public class AdresaRepository : GenericRepository<Adresa>, IAdresaRepository
    {
        public AdresaRepository(CasaContext context) : base(context)
        {

        }
        public Adresa GetAdresaAllDetails(int id)
        {
            return _table.Where(arg => arg.AdresaId == id)
                .FirstOrDefault();
        }

        public List<Adresa> GetAdresaAllDetails()
        {
            return _table
                .ToList();
        }
    }
}
