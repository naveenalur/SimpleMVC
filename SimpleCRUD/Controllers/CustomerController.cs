using SimpleCRUD.DataBase;
using SimpleCRUD.Dto;
using SimpleCRUD.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace SimpleCRUD.Controllers
{
    public class CustomerController : Controller
    {
        public SimpleCRUDContext Context;

        public CustomerController()
        {
            Context = new SimpleCRUDContext();
        }

        // GET: Customer
        public ActionResult CustomerDetail()
        {
            var customerDetail = Context.Customers.ToList();

            var sqlQuery =
               @"Select DateAdd(minute, DateDiff(minute, 0, CreateDateTime), 0), Count(*) From dbo.Customers Group By DateAdd(minute, DateDiff(minute, 0, CreateDateTime), 0)";
            var mydata = Context.Database.SqlQuery<AddedCustomerGraph>(sqlQuery).ToList();


            return View(customerDetail);
        }

        public ActionResult AddNewCustomer()
        {
            return View();
        }

        public ActionResult Create(Customer customer)
        {
            try
            {
                customer.CreateDateTime = DateTime.Now.ToLocalTime();
                Context.Customers.Add(customer);

                Context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return RedirectToAction("CustomerDetail");
        }
    }
}