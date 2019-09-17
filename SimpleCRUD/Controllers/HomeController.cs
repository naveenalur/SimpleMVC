using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleCRUD.DataBase;

namespace SimpleCRUD.Controllers
{
    public class HomeController : Controller
    {
        public SimpleCRUDContext Context;

        public HomeController()
        {
            Context = new SimpleCRUDContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //  ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public JsonResult CreateGraph()
        {

            var CustomerList = Context.Customers.ToList();

            return Json(CustomerList, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}