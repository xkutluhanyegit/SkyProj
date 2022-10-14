using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;

        OrderVM ovm = new OrderVM();
        IOrderService _orderService;
        IBrandService _brandService;
        ICustomerService _customerService;

        public OrderController(ILogger<OrderController> logger,IOrderService orderService,IBrandService brandService,ICustomerService customerService)
        {
            _logger = logger;
            _orderService = orderService;
            _brandService = brandService;
            _customerService = customerService;
        }

        [HttpGet("order-bilgileri")]
        public IActionResult Index()
        {
            var res = _orderService.GetAll();
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("order-ekle")]
        public IActionResult Add()
        {
          ovm.brands = _brandService.GetAll().Data;
          ovm.customers = _customerService.GetAll().Data;
          return View(ovm);
        }
        [HttpPost("order-ekle")]
        public IActionResult Add(Order order)
        {
          var res = _orderService.Add(order);
          if (res.Success)
          {
            return RedirectToAction("index","order");
          }
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}