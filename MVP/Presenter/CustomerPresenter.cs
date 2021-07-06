using MVP.Model;
using MVP.Repository;
using MVP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Presenter
{
    public class CustomerPresenter
    {
        ICustomerRepository repository;
        ICustomerView view;

        public CustomerPresenter(ICustomerView customerForm, ICustomerRepository rep)
        {
            this.view = customerForm;
            customerForm.customerPresenter = this;

            this.repository = rep;
            UpdateCustomerListView();
        }

        public void UpdateCustomerView(int id)
        {
            Customer customer = repository.GetCustomerByID(id);
            
            view.FullName = customer.FullName;
            view.Address = customer.Address;
            view.Email = customer.Email;
            view.Nationality = customer.Nationality;
        }


        
        public void AddCustomer() 
        {
            Customer customer = new Customer(view.FullName, view.Address, view.Email, view.Nationality);
            repository.AddCustomer(customer);

            UpdateCustomerListView();
        }



        public void SaveCustomer()
        {
            Customer customer = new Customer(view.FullName, view.Address, view.Email, view.Nationality);
            repository.SaveCustomer(view.SelectedCustomer, customer);

            UpdateCustomerListView();

        }

        private void UpdateCustomerListView()
        {
            var customerNames = repository.GetAllCustomers().Select(x => x.FullName);
            int selectedCustomer = view.SelectedCustomer >= 0 ? view.SelectedCustomer : 0;
            view.CustomerList = customerNames.ToList();
            view.SelectedCustomer = selectedCustomer;
        }

    }
}
