using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;
using Entities.Concrete;

namespace Web.Controllers
{
    public class SecondQuality : Controller
    {
        SecondQualityVM sqvm = new SecondQualityVM();
        private readonly ILogger<SecondQuality> _logger;
        ICustomerService _customerService;
        IBrandService _brandService;
        ISecondQualityService _secondQualityService;

        public SecondQuality(ILogger<SecondQuality> logger, ICustomerService customerService,IBrandService brandService,ISecondQualityService secondQualityService)
        {
            _logger = logger;
            _customerService = customerService;
            _brandService = brandService;
            _secondQualityService = secondQualityService;
        }

        [HttpGet("ikinci-kalite")]
        public IActionResult Index()
        {
            
            var res = _secondQualityService.GetSQDetails();
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("ikinci-kalite-urun-ekle")]
        public IActionResult Add()
        {
          sqvm.customers = _customerService.GetAll().Data;
          sqvm.brands = _brandService.GetAll().Data;
          return View(sqvm);
        }

        [HttpPost("ikinci-kalite-urun-ekle")]
        public IActionResult Add(Entities.Concrete.SecondQuality secondQuality)
        {
            var res = _secondQualityService.Add(secondQuality);
            if (res.Success)
            {
                return RedirectToAction("index","secondquality");
            }
          return View(secondQuality);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}