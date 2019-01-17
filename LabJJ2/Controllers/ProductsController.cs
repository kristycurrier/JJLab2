using LabJJ2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabJJ2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(ProductsModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["DataSaved"] = "You successfully saved the product";
                Session["LatestSave"] = DateTime.Now.ToShortDateString();
                return RedirectToRoute(new { controller = "Home", action = "Index" });

            }

            return View("Index", model);
        }
    }
}