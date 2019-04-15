using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstEFApp.Models;
using FirstEFApp.Repository;

namespace FirstEFApp.BLL
{
    public class CustomerManager
    {
        CustomerRepository customerRepository = new CustomerRepository();
        bool checker = false;
        public bool Add(Customer customer)
        {
            if (customerRepository.Add(customer))
            {
                checker = true;
            }
            return checker;
        }
        public Customer GetById( int id)
        {
            Customer customer = customerRepository.GetById(id);
            return customer;
        }
        public bool Delete(Customer customer)
        {
            if (customerRepository.Delete(customer))
            {
                checker = true;
            }
            else
            {
                checker = false;
            }
            return checker;
        }
        public bool Update(Customer customer)
        {
            if (customerRepository.Update(customer))
            {
                checker = true;
            }
            return checker;
        }
        public List<Customer> GetAllCustomer()
        {
            return (customerRepository.GetAllCustomer());
        }
       
    }
}