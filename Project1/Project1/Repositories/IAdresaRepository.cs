using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repositories
{
    public interface IAdresaRepository : IGenericRepository<Adresa>
    {
        Adresa GetAdresaAllDetails(int id);
        List<Adresa> GetAdresaAllDetails();
        List<Adresa> GetAllWithInclude();
    }
}
