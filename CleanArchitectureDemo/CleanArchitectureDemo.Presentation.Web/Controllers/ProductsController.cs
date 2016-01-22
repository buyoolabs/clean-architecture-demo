using CleanArchitectureDemo.Presentation.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CleanArchitectureDemo.Presentation.Web.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>();
        List<ProductDetails> productDetails = new List<ProductDetails>();
        public ProductsController()
        {
            products.Add(new Product() { ProductId = 1, Title = "Lenovo G570", Price = 1200.45m, Stock = 99 });
            products.Add(new Product() { ProductId = 2, Title = "Apple Macbook Pro", Price = 2600.99m, Stock = 23 });

            productDetails.Add(new ProductDetails() { ProductId = 1, Title = "Lenovo G570", Price = 1200.45m, Stock = 99, Brand = "Lenovo" });
            productDetails.Add(new ProductDetails() { ProductId = 2, Title = "Apple Macbook Pro", Price = 2600.99m, Stock = 23, Brand = "Apple" });
        }


        // GET: Products
        public ActionResult Index()
        {
            return View(products);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View(productDetails.Where(x=> x.ProductId == id).FirstOrDefault());
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
