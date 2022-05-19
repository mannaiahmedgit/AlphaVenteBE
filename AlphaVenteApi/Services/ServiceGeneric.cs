using AlphaVenteData.interfaces;
using AutoMapper;
using System.Linq.Expressions;

namespace AlphaVenteApi.Services
{
    public class ServiceGeneric<TEntity, TDto> : IServiceGeneric<TEntity, TDto>where TEntity : class
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<TEntity> _repository;

        public ServiceGeneric(IUnitOfWork<TEntity> repository , IMapper mapper)
        {
            this._mapper = mapper;
            this._repository = repository;  
        }
        public async Task Add(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _repository.Entity.Insert(entity);
            _repository.Save();
        }

        public async Task Delete(int id)
        {
            await _repository.Entity.Delete(await _repository.Entity.GetById(id));
        }

        public IEnumerable<TDto> GetAll(Expression<Func<TDto, bool>> expression = null)
        {
            var predicate = _mapper.Map<Expression<Func<TEntity, bool>>>(expression);
            return _repository.Entity.GetAll(predicate).Select(_mapper.Map<TDto>).ToList();
        }

        public async Task<TDto> GetById(int id)
        {
            var entity = await _repository.Entity.GetById(id);
            return _mapper.Map<TDto>(entity);
        }

        public async  Task<TDto> GetFirst(Expression<Func<TDto, bool>> expression = null)
        {
            var predicate = _mapper.Map<Expression<Func<TEntity, bool>>>(expression);
            var entity= await _repository.Entity.GetFirst(predicate);
            return _mapper.Map<TDto>(entity);
        }

        public async Task Update(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto); 
            await _repository.Entity.Update(entity);
            _repository.Save();
        }
    }
}
