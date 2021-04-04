using System.Linq;
using System.Threading.Tasks;
using core.DbContexts;
using infrastructure.Interfaces;

namespace infrastructure.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public Task<TEntity> AddAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _context.Set<TEntity>();
            }
            catch (System.Exception ex)
            {
                throw new System.Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public Task<TEntity> Updateasync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}