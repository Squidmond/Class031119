using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class031119.Controllers
{
    public class ShoppingListController : Controller
    {
        public IActionResult Add(string name, decimal price)
        {
            return Ok("Added your " + name);
        }
    }
}
