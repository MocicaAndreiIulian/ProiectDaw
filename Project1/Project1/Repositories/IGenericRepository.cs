using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repositories
{
        public interface IGenericRepository<T> where T : class 
        {
            void Create(T entity);
            void Update(T entity);
            void Delete(T entity);
            T FindById(object id);
            List<T> FindAll();
            bool SaveChanges();
        }
}
