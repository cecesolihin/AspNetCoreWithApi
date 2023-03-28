using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OrderApps.Models;

namespace OrderApps.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> Get(Customer customer);
        Task<IEnumerable<Customer>> Get(string customerId);
        Task<Customer> Create(Customer customer);
        Task Update(Customer customer);
        Task Delete(string customerId);
    }
}
