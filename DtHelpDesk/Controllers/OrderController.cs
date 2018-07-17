using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DtHelpDesk.Models;

namespace DtHelpDesk.Controllers {
    public class OrderController : Controller {
        private IOrderRepository repository;

        public OrderController(IOrderRepository repo) {
            repository = repo;
        }

        public ViewResult List() => View(repository.Orders);

        //public IActionResult Index() {
        //    return View();
        //}
    }
}