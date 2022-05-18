using AlphaVenteApi.Data;
using AlphaVenteData.interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace AlphaVenteApi.repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AlphaDbContext _alphaDbContext;
        private DbSet<T> table = null;


        public GenericRepository(AlphaDbContext alphaDbContext)
        {
            this._alphaDbContext = alphaDbContext;
            table = _alphaDbContext.Set<T>();

        }
        public  Task Delete(T entity)
        {
            table.Remove(entity);
            return Task.CompletedTask; 
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            var result = table.AsNoTracking();
            if (expression != null)
            {

                result= result.Where(expression);   
            }
            return result;
        }

        public async Task<T> GetById(int id)
        {
          
            return await table.FindAsync(id);
        }

        public async Task<T> GetFirst(Expression<Func<T, bool>> expression = null)
        {
            return await table.FirstOrDefaultAsync(expression);
        }

        public  Task Insert(T entity)
        {
              table.Add(entity);
            return Task.CompletedTask;
        }

        public  Task Update(T entity)
        {
            table.Attach(entity);
            _alphaDbContext.Entry(entity).State=EntityState.Modified;
            return Task.CompletedTask; 
        }
    }
}
