using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelOrigin.Core.Domain;
using System.Collections.ObjectModel;

namespace HotelOrigin.Core.Repository
{
    public class CustomerRepository
    {
        private static ObservableCollection<Customer> customers = new ObservableCollection<Customer>();

        //Create

        public static Customer Create()
        {
            Customer customer = new Customer();

            customers.Add(customer);

            return customer;
        }
        public static void Add(Customer customer)
        {
            customers.Add(customer);

        }

        //Read

        public static Customer GetById(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
            //Customer foundCustomer = null;

            //for (int i = 0; i <customers.Count; i ++)
            //{
            //  if(customers.ElementAt(i).Id ==id)
            //  {
            // foundCustomer = customers.ElementAt(i);
            //  }
            //} 

            // return foundCustomer;

        }
        public static ObservableCollection<Customer> GetAll()
        {
            return customers;

        }

        //Update

        public static void Update(Customer customer, int id, string firstName, string lastName, string telephone, string emailAddress)
        {
           

            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.TelephoneNumber = telephone;
            customer.EmailAddress = emailAddress;
            customer.Id = id;
           


            //Delete
        }

        public static void Delete(int id)
        {
            var customer = GetById(id);

            customers.Remove(customer);
        }
            public static void Delete(Customer customer)
        {
            customers.Remove(customer);
        }

        }
    }

