using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AlphaVenteData.interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression = null);
        Task<T> GetFirst(Expression<Func<T, bool>> expression = null);
        
    }
}
