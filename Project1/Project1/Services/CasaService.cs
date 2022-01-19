using Project1.Models;
using Project1.Repositories;
using Project1.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services
{
    public class CasaService : ICasaService
    {
        private readonly ICasaRepository _casaRepository;

        public CasaService(ICasaRepository casaRepository)
        {
            _casaRepository = casaRepository;
        }

        public Casa Create(Casa cat)
        {
            _casaRepository.Create(cat);
            _casaRepository.SaveChanges();

            return _casaRepository.GetCasaAllDetails(cat.CasaId);
        }
        public Casa Get(int id)
        {
            return _casaRepository.GetCasaAllDetails(id);
        }

        public bool Delete(int id)
        {
            var entity = _casaRepository.FindById(id);
            if (entity != null)
            {
                _casaRepository.Delete(entity);
                _casaRepository.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Casa> GetAll()
        {
            return _casaRepository.GetAllWithInclude();
        }

        public Casa Update(Casa cat)
        {
            if (_casaRepository.FindById(cat.CasaId) == null) return null;
            _casaRepository.Update(cat);
            _casaRepository.SaveChanges();
            return _casaRepository.GetCasaAllDetails(cat.CasaId);
        }
    }
}
