using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewTasks.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SprintTasks()
        {
            return View();
        }
        public IActionResult Greetings()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Supermarkets()
        {
            return View();
        }
        public IActionResult ShoppingList()
        {
           
            return View();
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult TimeToBuy()
        {
            return PartialView("_TimeToBuy");
        }

    }
}
