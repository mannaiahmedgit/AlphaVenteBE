using AlphaVenteData.interfaces;
using AutoMapper;
using System.Linq.Expressions;

namespace AlphaVenteApi.Services
{
    public class ServiceGeneric<TEntity, TDto> : IServiceGeneric<TEntity, TDto>where TEntity : class
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<TEntity> _repository;

        public ServiceGeneric(IGenericRepository<TEntity> repository , IMapper mapper)
        {
            this._mapper = mapper;
            this._repository = repository;  
        }
        public async Task Add(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _repository.Insert(entity);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(await _repository.GetById(id));
        }

        public IEnumerable<TDto> GetAll(Expression<Func<TDto, bool>> expression = null)
        {
            var predicate = _mapper.Map<Expression<Func<TEntity, bool>>>(expression);
            return _repository.GetAll(predicate).Select(_mapper.Map<TDto>).ToList();
        }

        public async Task<TDto> GetById(int id)
        {
            var entity = await _repository.GetById(id);
            return _mapper.Map<TDto>(entity);
        }

        public async  Task<TDto> GetFirst(Expression<Func<TDto, bool>> expression = null)
        {
            var predicate = _mapper.Map<Expression<Func<TEntity, bool>>>(expression);
            var entity= await _repository.GetFirst(predicate);
            return _mapper.Map<TDto>(entity);
        }

        public async Task Update(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto); 
            await _repository.Update(entity);
        }
    }
}
