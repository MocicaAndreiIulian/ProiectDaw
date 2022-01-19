using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services.IServices
{
    public interface IAdresaService
    {
        Adresa Create(Adresa adresa);
        Adresa Get(int id);
        Adresa Update(Adresa adresa);
        bool Delete(int id);
        List<Adresa> GetAll();
    }
}
