using AlphaVenteApi.Data;
using AlphaVenteApi.repositories;
using AlphaVenteData.interfaces;

namespace AlphaVenteApi.unitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly AlphaDbContext _context;
        public IGenericRepository<T> _entity;
        public IGenericRepository<T> Entity
        {
            get
            {
                return _entity ?? (_entity = new GenericRepository<T>(_context));
            }
        }



        public UnitOfWork(AlphaDbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
