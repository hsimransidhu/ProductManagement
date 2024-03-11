using PMBLL;
using ProductManagement;
using PMDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductManagement.Controllers
{
    public class TempProductController : Controller
    {
        // GET: TempProduct
        public ActionResult Index()
        {
            ProductService productService = new ProductService();
            var products = productService.GetProducts();
            return View(products);
        }
    }
}