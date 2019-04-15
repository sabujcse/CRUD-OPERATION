using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstEFApp.Models;
using FirstEFApp.DataBaseContext;
using FirstEFApp.BLL;
using System.Data;

namespace FirstEFApp.Controllers
{
    public class CustomerController : Controller
    {
        ShopContextDB DB = new ShopContextDB();
        CustomerManager Manager = new CustomerManager();
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Customer customer)
        { 
            if (Manager.Add(customer))
            {
                ViewBag.MSg = "Saved";
            }
            else
            {
                ViewBag.Msg = "Not Saved";
            }
            return View(customer);
        }
        [HttpGet]
       public ActionResult Update(int id)
        {
            Customer customer = Manager.GetById(id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult Update(Customer customer)
        {
            Customer cs = Manager.GetById(customer.Id);
            if (cs != null)
            {
                cs.Name = customer.Name;
                cs.Address = customer.Address;
                cs.Code = customer.Code;
                if (Manager.Update(cs))
                {
                    ViewBag.SMS = "Updated";
                }
                else
                {
                    ViewBag.SMS = "Not Update";
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
             
            Customer customer =  Manager.GetById(id);
            if (customer != null)
            {
                if (Manager.Delete(customer))
                {
                    ViewBag.SMS =  "Delete";
                }
                else
                {
                    ViewBag.SMS = "Not Delete";
                }
            }

            return View();
        }
        public ViewResult Show()
        {

            return View(Manager.GetAllCustomer());
        }
      
    }
}