using System.Linq.Expressions;

namespace AlphaVenteApi.Services
{
    public interface IServiceGeneric<TEntity,TDto>
    {
        Task Add(TDto dto);
        Task Delete(int id);
        IEnumerable<TDto> GetAll(Expression<Func<TDto,bool>>expression=null ); 

        Task<TDto> GetById(int id);
        Task Update(TDto dto);
        Task<TDto> GetFirst(Expression<Func<TDto, bool>> expression = null);
    }
}
