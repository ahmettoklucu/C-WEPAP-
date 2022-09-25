using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            //Product product = new Product()
            //{
            //    Name = "Telefon",
            //    Description="Akıllı Telefon",
            //    Price=15000,
            //    Status=true,
            //    IsDelete=false
            //};
            //db.Product.Add(product);
            //db.SaveChanges();
            return View();
        }
    }
}
