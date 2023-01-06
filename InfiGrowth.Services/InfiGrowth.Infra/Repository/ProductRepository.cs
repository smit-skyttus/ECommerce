using InfiGrowth.Entity.Manage;
using InfiGrowth.Infra.Context;
using InfiGrowth.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiGrowth.Infra.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly InfiGrowthContext _context;

        public ProductRepository(InfiGrowthContext context)
        {
                _context = context;
        }
        public async Task<Products> CreateProduct(Products product)
        {
            var result = _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Products> DeleteProducts(int productId)
        {
            var result = await GetProductById(productId);
            await _context.SaveChangesAsync();
            return result;
        }

        public async Task<List<Products>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Products> GetProductById(int productId)
        {
           return await _context.Products.FirstAsync(p => p.ProductId == productId);
        }

        public async Task<Products> UpdateProduct(Products product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}
