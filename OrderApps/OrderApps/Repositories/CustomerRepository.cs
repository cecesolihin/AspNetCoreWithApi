using OrderApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApps.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task<Customer> Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> Get(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> Get(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
