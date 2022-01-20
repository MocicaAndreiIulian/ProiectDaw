using Project1.Models;
using Project1.Repositories;
using Project1.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services
{
    public class AdresaService : IAdresaService
    {
        private readonly IAdresaRepository _adresaRepository;

        public AdresaService(IAdresaRepository adresaRepository)
        {
            _adresaRepository = adresaRepository;
        }

        public Adresa Create(Adresa cat)
        {
            _adresaRepository.Create(cat);
            _adresaRepository.SaveChanges();

            return _adresaRepository.GetAdresaAllDetails(cat.AdresaId);
        }
        public Adresa Get(int id)
        {
            return _adresaRepository.GetAdresaAllDetails(id);
        }

        public bool Delete(int id)
        {
            var entity = _adresaRepository.FindById(id);
            if (entity != null)
            {
                _adresaRepository.Delete(entity);
                _adresaRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Adresa> GetAll()
        {
            return _adresaRepository.GetAllWithInclude();
        }

        public Adresa Update(Adresa cat)
        {
            if (_adresaRepository.FindById(cat.AdresaId) == null) return null;
            _adresaRepository.Update(cat);
            _adresaRepository.SaveChanges();
            return _adresaRepository.GetAdresaAllDetails(cat.AdresaId);
        }
    }
}
