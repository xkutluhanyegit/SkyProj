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
    public class BrandController : Controller
    {
        private readonly ILogger<BrandController> _logger;
        IBrandService _brandService;
        public BrandController(ILogger<BrandController> logger, IBrandService brandService)
        {
            _logger = logger;
            _brandService = brandService;
        }

        [HttpGet("marka-bilgileri")]
        public IActionResult Index()
        {
            var res = _brandService.GetAll();
            if (res.Success)
            {
                return View(res.Data);
            }
            return View();
        }

        [HttpGet("marka-ekle")]
        public IActionResult Add()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        [HttpPost("marka-ekle")]
        public IActionResult Add(Brand brand)
        {
          var res = _brandService.Add(brand);
          if (res.Success)
          {
            return RedirectToAction("index","brand");
          }
          return View(brand);
        }

        [HttpGet("marka-guncelle")]
        public IActionResult Update(int id)
        {
          var res = _brandService.GetById(id);
          if (res.Success)
          {
            return View(res.Data);
          }
          return View();
        }

        [HttpPost("marka-guncelle")]
        public IActionResult Update(Brand brand)
        {
          var res = _brandService.Update(brand);
          if (res.Success)
          {
            return View(res);
          }
          return View();
        }

        [HttpGet("marka-sil")]
        public IActionResult Delete(int id)
        {
            var res = _brandService.Delete(_brandService.GetById(id).Data);
            if (res.Success)
            {
                return RedirectToAction("index","Brand");
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