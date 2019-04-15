using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstEFApp.Models;
using FirstEFApp.DataBaseContext;
using System.Data.Entity;
using System.Data;


namespace FirstEFApp.Repository
{
    public class CustomerRepository
    {
        ShopContextDB DB = new ShopContextDB();
        public bool checkFlag = false;
        public bool Add(Customer customer)
        {
            DB.Customers.Add(customer);
            if(DB.SaveChanges()>0)
            {
                checkFlag = true;
            }
            return checkFlag;
        }
        public Customer GetById( int id)
        {
            Customer customer = DB.Customers.Where(c => c.Id == id).FirstOrDefault();
            return customer;
        }
        public bool Delete(Customer customer)
        {

            DB.Customers.Remove(customer);
            if (DB.SaveChanges() > 0)
            {
                checkFlag = true;
            }
            return checkFlag;
        }
        public bool Update(Customer customer)
        {
            DB.Entry(customer).State = EntityState.Modified;
            if (DB.SaveChanges() > 0)
            {
                checkFlag = true;
            }
            return checkFlag;
        }
        public List<Customer> GetAllCustomer()
        {
            return (DB.Customers.ToList());
        }
    }
}