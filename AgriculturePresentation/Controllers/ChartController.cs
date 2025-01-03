﻿using AgriculturePresentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductChart()
        {
            List<ProductClass> productClasses = new List<ProductClass>();
            productClasses.Add(new ProductClass
            {
                productname="Buğday",
                productvalue=850

            });
            productClasses.Add(new ProductClass
            {
                productname = "Mercimek",
                productvalue = 120
            });
            productClasses.Add(new ProductClass
            {
                productname = "Pirinç",
                productvalue = 140
            });
            productClasses.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 630
            });
            productClasses.Add(new ProductClass
            {
                productname = "Domates",
                productvalue = 740
            });
            return Json(new {jsonlist=productClasses});
        }
    }
}
