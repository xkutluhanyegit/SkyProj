using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        ICustomerService _customerService;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet("musteri-bilgileri")]
        public IActionResult Index()
        {
            var res = _customerService.GetAll();
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("musteri-ekle")]
        public IActionResult Add()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }
        [HttpPost("musteri-ekle")]
        public IActionResult Add(Customer customer)
        {
            var res = _customerService.Add(customer);
            if (res.Success)
            {
                return RedirectToAction("index", "Customer");
            }
            //TODO: Implement Realistic Implementation
            return View(customer);
        }

        [HttpGet("musteri-sil")]
        public IActionResult Delete(int id)
        {
            var res = _customerService.Delete(_customerService.GetById(id).Data);
            if (res.Success)
            {
                return RedirectToAction("index","Customer");
            }
            return View();
        }

        [HttpGet("musteri-guncelle")]
        public IActionResult Update(int id)
        {
          var res = _customerService.GetById(id);
          if (res.Success)
          {
            return View(res.Data);
          }
          return View();
        }

        [HttpPost("musteri-guncelle")]
        public IActionResult Update(Customer customer)
        {
          var res = _customerService.Update(customer);
          if (res.Success)
          {
            return View(res);
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