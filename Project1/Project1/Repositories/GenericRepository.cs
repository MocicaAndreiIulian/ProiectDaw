using Microsoft.EntityFrameworkCore;
using Project1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected readonly CasaContext _context;
        protected readonly DbSet<T> _table;

        public GenericRepository(CasaContext context)
        {
            _context = context;
            _table = context.Set<T>();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _table.Remove(entity);
        }

        public List<T> FindAll()
        {
            return _table.ToList();
        }


        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(T entity)
        {
            _table.Update(entity);
        }

        public T FindById(object id)
        {
            var result = _table.Find(id);
            _context.Entry(result).State = EntityState.Detached;
            return result;
        }
    }
}
