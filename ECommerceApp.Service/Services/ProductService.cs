using ECommerceApp.Core.IUnitOfWorks;
using ECommerceApp.Core.Models;
using ECommerceApp.Core.Repositories;
using ECommerceApp.Core.Services;

namespace ECommerceApp.Service.Services
{
    public class ProductService : Service<Product> , IProductService
    {
        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }

    
}
