using Microsoft.AspNetCore.Mvc;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class APIController : Controller
    {
        private readonly CoffeeContext db;
        public APIController(CoffeeContext context)
        {
            db = context;
        }
        public IActionResult loadAll()
        {
            int btn = 0;
            var q = db.Products;
            btn = q.Count() / 15;
            return Content($"{btn}", "text/plain", System.Text.Encoding.UTF8);
        }
        public IActionResult loadCatory(int id)
        {
            int btn = 0;
            var q = db.Products.Where(p => p.CategoryId == id);
            btn = q.Count() / 15;
            return Content($"{btn}", "text/plain", System.Text.Encoding.UTF8);
        }
        public IActionResult loadCountry(int id)
        {
            int btn = 0;
            var q = db.Coffees.Where(p => p.CountryId == id);
            btn = q.Count() / 15;
            return Content($"{btn}", "text/plain", System.Text.Encoding.UTF8);
        }
        public IActionResult loadRoast(int id)
        {
            int btn = 0;
            var q = db.Coffees.Where(p => p.RoastingId == id);
            btn = q.Count() / 15;
            return Content($"{btn}", "text/plain", System.Text.Encoding.UTF8);
        }
        public IActionResult loadProcess(int id)
        {
            int btn = 0;
            var q = db.Coffees.Where(p => p.ProcessId == id);
            btn = q.Count() / 15;
            return Content($"{btn}", "text/plain", System.Text.Encoding.UTF8);
        }
        public IActionResult loadPacking(int id)
        {
            int btn = 0;
            var q = db.Coffees.Where(p => p.PackageId == id);
            btn = q.Count() / 15;
            return Content($"{btn}", "text/plain", System.Text.Encoding.UTF8);
        }
    }
}
