using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repositories
{
    public interface ICasaRepository : IGenericRepository<Casa>
    {
        Casa GetCasaAllDetails(int id);
        List<Casa> GetCaseAllDetails();
        List<Casa> GetAllWithInclude();
        List<Casa> GetAllWithJoin();
    }
}
