using CleanArchitecture.Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infraestructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        protected BdempresaContext _context;
        public ProductRepository(BdempresaContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Product> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<int> Insert(Product product)
        {
            await _context.Products.AddAsync(product);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Update(Product product)
        {
            _context.Update(product);
            return await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            //Product product = new Product { Id = id };
            //_context.Entry(product).State = EntityState.Deleted;
            //return await

        }
