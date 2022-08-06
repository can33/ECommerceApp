using ECommerceApp.Core.IUnitOfWorks;
using ECommerceApp.Core.Models;
using ECommerceApp.Core.Repositories;
using ECommerceApp.Core.Services;

namespace ECommerceApp.Service.Services
{
    public class BrandService : Service<Brand>, IBrandService
    {
        public BrandService(IGenericRepository<Brand> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
