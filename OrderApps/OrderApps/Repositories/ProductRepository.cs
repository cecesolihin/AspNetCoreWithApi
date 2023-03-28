using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderApps.Models;
using OrderApps.Data;
using System.Data.SqlClient;
using Dapper;

namespace OrderApps.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DapperContext _context;
        public ProductRepository(DapperContext context)
        {
            _context = context;
        }
        

        public async Task<IEnumerable<Product>> Get(Product product)
        {
            //Product product = new Product();
            //product.ProductId = "";
            // product.ProductName = "";
            string producid = string.IsNullOrEmpty(product.ProductId) ? "" : product.ProductId;
            string producname = string.IsNullOrEmpty(product.ProductName) ? "" : product.ProductName;
            var query = "exec [dbo].[Sp_Product_Search] @ProductId, @ProductName";
            using (var connection = _context.CreateConnection())
            {
                var products =  connection.Query<Product>(query, new {producid,producname }).ToList();
                return products;
            }
        }

        public Task<Product> Get(string productId)
        {
            throw new NotImplementedException();
        }
        public Task<Product> Create(Product product)
        {
            throw new NotImplementedException();
        }
        public Task Update(Product product)
        {
            throw new NotImplementedException();
        }
        public Task Delete(string productId)
        {
            throw new NotImplementedException();
        }
    }
}
