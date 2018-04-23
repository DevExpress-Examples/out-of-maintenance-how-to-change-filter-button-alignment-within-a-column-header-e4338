using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace DxSample
{
    public static class DataHelper
    {
        public static ObservableCollection<Customer> GetData()
        {
            ObservableCollection<Customer> customers = new ObservableCollection<Customer>()
            {
                new Customer("Maria", " Anders", "Berlin", "Germany"),
                new Customer("Antonio","Moreno","México D.F.","Mexico")
            };
            return customers;
        }

    }

    public class Customer
    {
        public Customer(string firstName, string lastName, string city, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            Country = country;
        }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        
    }
}
