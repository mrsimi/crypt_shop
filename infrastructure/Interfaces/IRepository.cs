using System.Threading.Tasks;
using System.Linq;
namespace infrastructure.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> Updateasync(TEntity entity);
    }
}