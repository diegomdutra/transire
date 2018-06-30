using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TransireWebStore.Models;

namespace TransireWebStore.Controllers
{
    public class HomeController : Controller
    {
        private transirestoredbEntities db = new transirestoredbEntities();

        public ActionResult Index(int? id)
        {
            if(id > 0)
                ViewBag.Products = db.Product.Where(p => p.prod_cat_id == id);
            else
                ViewBag.Products = db.Product.ToList();

            ViewBag.Categories = db.Category.ToList();
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

        public ActionResult Category(int? id)
        {
            ViewBag.Products = db.Product.Where(p => p.prod_cat_id == id);
            ViewBag.Categories = db.Category.ToList();
            return View();
        }
    }
}