using Microsoft.AspNetCore.Mvc;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class ShopController : Controller
    {
        CoffeeContext db = new CoffeeContext();
        public IActionResult view()
        {
            var q = db.Products;
            return View(q);
        }
        public IActionResult detail(int? id)
        {
            Product pd = new Product();
            var q = db.Products.FirstOrDefault(p => p.ProductId == id);
            pd.ProductId = q.ProductId;
            pd.ProductName = q.ProductName;

            pd.CountryId = q.CountryId;
            pd.Price = q.Price;
            pd.Description = q.Description;
            pd.Stock = q.Stock;
            pd.TakeDown = q.TakeDown;
            pd.Star = q.Star;
            return View(pd);
        }
    }
}
