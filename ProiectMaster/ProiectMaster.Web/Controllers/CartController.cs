using Microsoft.AspNetCore.Mvc;
using ProiectMaster.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMaster.Web.Controllers
{
    [Route("[Controller]")]
    public class CartController : Controller
    {
        private readonly IProductService productService;

        public CartController(IProductService service)
        {
            this.productService = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = productService.GetAllProducts();
            return View(list);
        }
    }
}
