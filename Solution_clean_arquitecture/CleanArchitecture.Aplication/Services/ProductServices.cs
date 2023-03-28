using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class ProductServices
    {
        protected IProductRepository _productRepository;
        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }
        public async Task <Product>> Getall()
        {
            return await _productRepository.GetAll();
        }
        public async Task<Product> GetById(int id);

        public class IProductRepository
        {
            
        }
    }
}
