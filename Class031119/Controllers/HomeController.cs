using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Class031119.Controllers
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public Microsoft.AspNetCore.Mvc.IActionResult Index()
        {
            return Redirect("/index.html");
        }
        //// Responds to GET/POST/PUT/DELETE on path /, /home, and /home/index
        //public string Index(string id = "world")
        //{
        //    return "Hello " + id;
        //}

        //// Responds to GET/POST/PUT/DELETE on path /Home/Goodbye
        //public string Goodbye()
        //{
        //    return "Goodbye World";
        //}
        ////This one responds ok on /home/food/1, home/food/2, and /home/food/3, but any other ID value will throw an error!
        ////You get helpful errors because your developer exception page is enabled in Startup.  This *should* be turned
        ////off in production sites, though.  This will also respond on /home/food?id=1, home/food?id=2, and /home/food?id=3
        //public string Food(int id, string topping = "plain")
        //{
        //    Dictionary<int, string> foods = new Dictionary<int, string>();
        //    foods.Add(1, "Hamburger");
        //    foods.Add(2, "Chili Dog");
        //    foods.Add(3, "Fries");

        //    string selectedFood = foods[id];
        //    return selectedFood + " with " + topping;
        //}
        ////To use Json, I had to change startup: services.AddMvcCore().AddJsonFormatters();
        ////My controller actions typically respond with common web server action results: 
        ////status codes, redirects, files, content, JSON, or HTML
        ////There are built-in methods on the Controller class to create all of these.
        ////Each action type implements the IActionResult interface, so we usually make that the return type for our actions
        //public IActionResult AllFoods()
        //{
        //    string[] foods = { "Hamburger", "Chili Dog", "Fries" };


        //    if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
        //    {
        //        return this.NotFound();
        //    }

        //    return this.Json(foods);
        //}
        //private static List<string> names = new List<string>();
        //public IActionResult Test(string name)
        //{
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        return this.Redirect(url: "index");
        //    }
        //    names.Add(item: name);

        //    return this.Json(names);
        //}
    }
}
