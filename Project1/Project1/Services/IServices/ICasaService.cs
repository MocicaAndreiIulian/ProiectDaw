using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services.IServices
{
    public interface ICasaService
    {
        Casa Create(Casa casa);
        Casa Get(int id);
        Casa Update(Casa casa);
        bool Delete(int id);
        List<Casa> GetAll();
    }
}
