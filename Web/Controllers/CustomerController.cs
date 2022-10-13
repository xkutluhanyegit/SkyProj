using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet("musteri-bilgileri")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet("musteri-ekle")]
        public IActionResult Add()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        [HttpPost("musteri-ekle")]
        public IActionResult Add(string customer)
        {
          //TODO: Implement Realistic Implementation
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}