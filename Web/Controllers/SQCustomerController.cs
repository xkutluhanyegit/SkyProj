using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Web.Controllers
{
    public class SQCustomerController : Controller
    {
        private readonly ILogger<SQCustomerController> _logger;

        ISQCustomerService _sQCustomerService;

        public SQCustomerController(ILogger<SQCustomerController> logger, ISQCustomerService sQCustomerService)
        {
            _logger = logger;
            _sQCustomerService = sQCustomerService;
        }

        [HttpGet("/ikinci-kalite-musteri-bilgisi")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/ikinci-kalite-musteri-ekle")]
        public IActionResult Add()
        {
            //TODO: Implement Realistic Implementation
            return View();
        }

        [HttpPost("/ikinci-kalite-musteri-ekle")]
        public IActionResult Add(SQCustomer sQCustomer)
        {
            var res = _sQCustomerService.Add(sQCustomer);
            if (res.Success)
            {
                return RedirectToAction("index", "SQCustomer");
            }
            return View(sQCustomer);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}