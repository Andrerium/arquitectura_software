using CleanArchitecture.Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    internal class IProductRepository
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
    }
}
