using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Model
{
    public class Customer
    {
        public string FullName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Nationality { get; set; }

        public Customer(string fullName, string address, string email, string nationality)
        {
            FullName = fullName;
            Address = address;
            Email = email;
            Nationality = nationality;
        }

        public Customer()
        {
            FullName = "";
            Address = "";
            Email = "";
            Nationality = "";
        }


    }
}
