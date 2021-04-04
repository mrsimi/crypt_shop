using System.Threading.Tasks;
using core.Models;

namespace infrastructure.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
    }
}