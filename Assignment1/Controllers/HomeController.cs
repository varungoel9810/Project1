using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment1.Models;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Table tb)
        {
            using(Database1Entities entities = new Database1Entities())
            {
                if(ModelState.IsValid)
                {
                    entities.Tables.Add(tb);
                    try
                    {
                        entities.SaveChanges();
                    }
                    catch(DbEntityValidationException e)
                    {
                        Console.WriteLine(e);
                    }
                   
                    
                    ViewBag.Success = "Data Inserted";
                    ModelState.Clear();
                }
            }
            return View(tb);
        }
        public ActionResult SendEmail() {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}