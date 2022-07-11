﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class ShopController : Controller
    {
        
        private readonly CoffeeContext db;
        public ShopController(CoffeeContext context )
        {
            db = context;
        }


        public IActionResult view()
        {


            var q = db.Products.Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Country = p.Country,
                Coffee = p.Coffee,
                Price = p.Price,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star
            });
            return View(q);
        }

        public IActionResult detail(int? id)
        {

            var q = db.Products.Where(p=>p.ProductId==id).Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Coffee=p.Coffee,
                Country = p.Country,
                Price = p.Price,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star

            }).ToList();
            return View(q[0]);
        }
       
        public IActionResult addToCart(int? id)
        {

            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                CProductViewModel pd = new CProductViewModel();
                var q = db.Products.FirstOrDefault(p => p.ProductId == id);
                pd.ProductId = q.ProductId;
                pd.ProductName = q.ProductName;
                pd.CategoryId = q.CategoryId;
                var q1 = db.Categories.FirstOrDefault(p => p.CategoryId == q.CategoryId);
                pd.CategoryName = q1.CategoriesName;
                pd.Country = q.Country;
                pd.Price = q.Price;
                pd.Coffee = q.Coffee;
                pd.Description = q.Description;
                pd.Stock = q.Stock;
                pd.TakeDown = q.TakeDown;
                pd.Star = q.Star;
                return View(pd);
            }
            else
            {
                
                return RedirectToAction("Login","Home");
            }
           
        }

        public IActionResult partialView(int id)
        {
            int pagesize=15;
            int now = 0;

                now = (id - 1) * pagesize;

            var q = db.Products.Skip(now).Take(pagesize).Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Coffee = p.Coffee,
                Country = p.Country,
                Price = p.Price,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star
            });

            return PartialView(q);
        }

        public IActionResult partialViewForCatgory(int id ,int page)
        {
            int pagesize = 15;
            int now = 0;
            now = (page - 1) * pagesize;
            var q = db.Products.Where(p => p.CategoryId == id).Skip(now).Take(pagesize).Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Country = p.Country,
                Price = p.Price,
                Coffee = p.Coffee,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star
            });
            return PartialView(q);
        }
        public IActionResult partialViewContry(int id, int page)
        {
            int pagesize = 15;
            int now = 0;
            now = (page - 1) * pagesize;
            var q = db.Coffees.Where(p => p.CountryId == id).Skip(now).Take(pagesize).Select(p => new CCoffeeViewModel()
            {
                ProductId = p.ProductId,
                CoffeeId = p.CoffeeId,
                CoffeeName = p.CoffeeName,
                CountryId = p.CountryId,
                RoastingId = p.RoastingId,
                ProcessId = p.ProcessId,
                PackageId = p.PackageId,
                ConstellationId = p.ConstellationId,
                RainForest = p.RainForest,
                Country = p.Country,
                Package = p.Package,
                Process = p.Process,
                Product = p.Product,
                Roasting = p.Roasting
            });
            return PartialView(q);
        }
        public IActionResult partialViewRoast(int id ,int page)
        {
            int pagesize = 15;
            int now = 0;
            now = (page - 1) * pagesize;
            var q = db.Coffees.Where(p => p.RoastingId == id).Skip(now).Take(pagesize).Select(p => new CCoffeeViewModel()
            {
                ProductId = p.ProductId,
                CoffeeId = p.CoffeeId,
                CoffeeName = p.CoffeeName,
                CountryId = p.CountryId,
                RoastingId = p.RoastingId,
                ProcessId = p.ProcessId,
                PackageId = p.PackageId,
                ConstellationId = p.ConstellationId,
                RainForest = p.RainForest,
                Country = p.Country,
                Package = p.Package,
                Process = p.Process,
                Product = p.Product,
                Roasting = p.Roasting
            });
            return PartialView(q);
        }
        public IActionResult partialViewProcess(int id, int page)
        {
            int pagesize = 15;
            int now = 0;
            now = (page - 1) * pagesize;
            var q = db.Coffees.Where(p => p.ProcessId == id).Skip(now).Take(pagesize).Select(p => new CCoffeeViewModel()
            {
                ProductId = p.ProductId,
                CoffeeId = p.CoffeeId,
                CoffeeName = p.CoffeeName,
                CountryId = p.CountryId,
                RoastingId = p.RoastingId,
                ProcessId = p.ProcessId,
                PackageId = p.PackageId,
                ConstellationId = p.ConstellationId,
                RainForest = p.RainForest,
                Country = p.Country,
                Package = p.Package,
                Process = p.Process,
                Product = p.Product,
                Roasting = p.Roasting
            });
            return PartialView(q);
        }
        public IActionResult partialViewPacking(int id, int page)
        {
            int pagesize = 15;
            int now = 0;
            now = (page - 1) * pagesize;
            var q = db.Coffees.Where(p => p.PackageId == id).Skip(now).Take(pagesize).Select(p => new CCoffeeViewModel()
            {
                ProductId = p.ProductId,
                CoffeeId = p.CoffeeId,
                CoffeeName = p.CoffeeName,
                CountryId = p.CountryId,
                RoastingId = p.RoastingId,
                ProcessId = p.ProcessId,
                PackageId = p.PackageId,
                ConstellationId = p.ConstellationId,
                RainForest = p.RainForest,
                Country = p.Country,
                Package = p.Package,
                Process = p.Process,
                Product = p.Product,
                Roasting = p.Roasting
            });
            return PartialView(q);
        }
        public IActionResult partialViewBtnForCatgory(int id)
        {
            var q = db.Products.Where(p => p.CategoryId == id).Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Country = p.Country,
                Price = p.Price,
                Coffee = p.Coffee,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star

            });
            return PartialView(q);
        }

    }
}
