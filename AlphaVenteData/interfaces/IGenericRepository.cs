using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVenteData.interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetById(int id);
        void Insert(T entity);
        void Update(T entity);  
        void Delete(T entity);
      
        
    }
}
