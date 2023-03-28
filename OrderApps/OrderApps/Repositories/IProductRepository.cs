using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderApps.Models;

namespace OrderApps.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> Get(Product product);
        Task<Product> Get(string productId);
        Task<Product> Create(Product product);
        Task Update(Product product);
        Task Delete(string productId);
    }
}
