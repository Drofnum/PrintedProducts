using Microsoft.EntityFrameworkCore;
using PrintedProducts.Data;
using PrintedProducts.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Printedproducts.Services
{
    public class ProductService : IProductListing
    {
        private readonly ApplicationDbContext context;

        public ProductService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Products> GetAll()
        {
            return context.Products;
        }

        public Products GetById(int id)
        {
            var products = context.Products
                .Where(p => p.Id == id)
                .FirstOrDefault();

            return products;
        }

        public IEnumerable<Products> GetByType(string type)
        {
            var products = context.Products
                .Where(p => p.ProductType == type);

            return products;
        }
    }
}
