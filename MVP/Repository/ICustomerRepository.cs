using MVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerByID(int id);

        void SaveCustomer(int id, Customer customer);
        void AddCustomer(Customer customer);


    }
}
