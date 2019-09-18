using SimpleCRUD.DataBase;
using SimpleCRUD.Dto;
using SimpleCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
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
        [Obsolete]
        public ActionResult CustomerDetail()
        {
            var customerDetail = Context.Customers.ToList();

            //var sqlQuery =
            //   @"Select DateAdd(minute, DateDiff(minute, 0, CreateDateTime), 0), Count(*) From dbo.Customers Group By DateAdd(minute, DateDiff(minute, 0, CreateDateTime), 0)";


            // var d = (from name in customerDetail group name.Name by name.CreateDateTime)


            //var res = Context.Database.SqlQuery<AddedCustomerGraph>(
            //        "Select DateAdd(minute, DateDiff(minute, 0, CreateDateTime), 0) as CreatedDateTimeRange, Count(*) as Counts From dbo.Customers Group By DateAdd(minute, DateDiff(minute, 0, CreateDateTime), 0)").ToList();


            //using (var con = new EntityConnection("name=SimpleCRUDContext"))
            //{
            //    con.Open();
            //    EntityCommand cmd = con.CreateCommand();
            //    cmd.CommandText = "Select DateAdd(minute, DateDiff(minute, 0, CreateDateTime), 0) as CreatedDateTimeRange, Count(*) as Counts From SimpleCRUDContext.Customers Group By DateAdd(minute, DateDiff(minute, 0, CreateDateTime), 0)";
            //    Dictionary<String, int> dict = new Dictionary<string, int>();
            //    using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
            //    {
            //        while (rdr.Read())
            //        {
            //            string a = rdr.GetString(0);
            //            int b = rdr.GetInt32(1);
            //            dict.Add(a, b);
            //        }
            //    }
            //}




            //var result = customerDetail.SelectMany(i => customerDetail,
            //        (first, second) => new { First = first, Second = second })
            //    .Where(i => i.First != i.Second).AsEnumerable().AsQueryable()
            //    .Where(i => EntityFunctions.DiffMinutes(i.First.CreateDateTime, i.Second.CreateDateTime) >= 1)
            //    .Select(i => i.First)
            //    .Distinct()
            //    .OrderByDescending(i => i.CreateDateTime);


            List<Customer> data = null;
            var parameters = new List<SqlParameter>();


            // var queryString = @"Select DateAdd(minute, DateDiff(minute, 0, CreateDateTime), 0) as Key, Count(*) as Value From dbo.Customers Group By DateAdd(minute, DateDiff(minute, 0, CreateDateTime), 0) ";




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