using MVP.Model;
using MVP.Presenter;
using System.Collections.Generic;

namespace MVP.View
{
    public interface ICustomerView
    {
        IList<string> CustomerList { get; set; }

        int SelectedCustomer { get; set; }

        string Address {get; set;}

        string FullName { get; set; }

        string Email { get; set; }

        string Nationality { get; set; }

        CustomerPresenter customerPresenter { get; set; }

    }
}
