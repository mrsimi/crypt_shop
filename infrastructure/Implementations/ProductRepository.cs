using System.Linq;
using System.Threading.Tasks;
using core.DbContexts;
using core.Models;
using infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Implementations
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}