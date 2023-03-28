using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderApps.Data;
using OrderApps.Models;
using OrderApps.Repositories;
namespace OrderApps.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository repo;
        public ProductsController(IProductRepository productRepository)
        {
            repo = productRepository;
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> ProductAll([FromBody] Product product)
        {
            return await repo.Get(product);
        }
    }
}
