using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_System.Controllers
{
    public class ProductController : Controller
    {
        // Action
        public IActionResult Index()
        {
            return View();
        }

        // Method
        public void CreateProduct(string id, string name, string quantity, string discontinue)
        {
            
        }
    }
}
