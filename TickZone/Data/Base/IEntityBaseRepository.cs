using TickZone.Models;

namespace TickZone.Data.Base
{
    public interface IEntityBaseRepository<T> where T: class ,IEntityBase,new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);

        Task AddAsync(T entity);

        Task UpdateAsync(int Id, T entity);


        Task DeleteAsync(int id);

    }
}
