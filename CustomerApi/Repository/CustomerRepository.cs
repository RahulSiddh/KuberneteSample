using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApi.Model;

namespace CustomerApi.Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomer();
    }
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomer()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "FC1", LastName = "LC1", Age = 20 });
            customers.Add(new Customer { Id = 2, FirstName = "FC2", LastName = "LC2", Age = 50 });
            return customers;
        }
    }
}
