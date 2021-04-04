using System;
using System.Threading.Tasks;
using infrastructure.Interfaces;

namespace infrastructure.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository{ get; }
        Task<int> SaveChanges();
    }
}