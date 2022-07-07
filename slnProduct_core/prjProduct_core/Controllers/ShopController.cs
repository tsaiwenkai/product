using Microsoft.AspNetCore.Mvc;
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
        public ShopController(CoffeeContext context)
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
            CProductViewModel pd = new CProductViewModel();
            var q = db.Products.FirstOrDefault(p => p.ProductId == id);
            pd.ProductId = q.ProductId;
            pd.ProductName = q.ProductName;
            pd.CategoryId = q.CategoryId;
            var q1 = db.Categories.FirstOrDefault(p => p.CategoryId == q.CategoryId);
            pd.CategoryName = q1.CategoriesName;
            pd.Country = q.Country;
            pd.Price = q.Price;
            pd.Description = q.Description;
            pd.Stock = q.Stock;
            pd.TakeDown = q.TakeDown;
            pd.Star = q.Star;
            return View(pd);
        }
        public IActionResult addToCart(int? id)
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
            pd.Description = q.Description;
            pd.Stock = q.Stock;
            pd.TakeDown = q.TakeDown;
            pd.Star = q.Star;
            return View(pd);
        }
        public IActionResult partialView()
        {
            var q = db.Products.Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Country = p.Country,
                Price = p.Price,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star
            });
            return PartialView(q);
        }

        public IActionResult partialViewForCatgory(int id)
        {

            var q = db.Products.Where(p => p.CategoryId == id).Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Country = p.Country,
                Price = p.Price,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star
            });
            return PartialView(q);
        }
        public IActionResult partialViewContry(int id)
        {
            var q = db.Coffees.Where(p => p.CountryId == id).Select(p => new CCoffeeViewModel()
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
        public IActionResult partialViewRoast(int id)
        {
            var q = db.Coffees.Where(p => p.RoastingId == id).Select(p => new CCoffeeViewModel()
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
        public IActionResult partialViewProcess(int id)
        {
            var q = db.Coffees.Where(p => p.ProcessId == id).Select(p => new CCoffeeViewModel()
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
        public IActionResult partialViewPacking(int id)
        {
            var q = db.Coffees.Where(p => p.PackageId == id).Select(p => new CCoffeeViewModel()
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
        public IActionResult partialViewContinent(int id)
        {
            var q = db.Coffees.Where(p => p.ConstellationId == id).Select(p => new CCoffeeViewModel()
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

    }
}
