//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DtHelpDesk.Models;

namespace DtHelpDesk.Controllers {
    public class HomeController : Controller {
        public ViewResult Index() {
            return View("NewIndex");
        }

        [HttpGet]
        public ViewResult NewOrder() {
            return View();
        }

        [HttpPost]
        public ViewResult NewOrder(WorkOrderModel order) {
            if (ModelState.IsValid) {
                WorkOrderRepository.AddOrder(order);
                return View("OrderSaved", order);
            }
            else {
                return View();
            }
        }

        public ViewResult ShowAllOrders() {
            return View(WorkOrderRepository.Orders);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
