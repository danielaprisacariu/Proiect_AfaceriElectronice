using Microsoft.AspNetCore.Mvc;
using ProiectMaster.Models.Interfaces;
using System.Collections.Generic;

namespace ProiectMaster.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = productService.GetAllProducts();
            return View(products);
        }

        [HttpGet]
        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            var product = productService.GetProduct(id);
            return View(product);
        }

        [HttpPost]
        [Route("Add/{id}")]
        public IActionResult Add(int id)
        {
            var shopList = HttpContext.Session.Get<List<int>>(SessionHelper.ShoppingCart);

            if (shopList == null)
                shopList = new List<int>();

            if (!shopList.Contains(id))
                shopList.Add(id);

            HttpContext.Session.Set(SessionHelper.ShoppingCart, shopList);

            return RedirectToAction("Index", "Home", productService.GetAllProducts());
        }

        [HttpPost]
        [Route("Remove/{id}")]
        public IActionResult Remove(int id)
        {
            var shopList = HttpContext.Session.Get<List<int>>(SessionHelper.ShoppingCart);

            if (shopList == null)
                return RedirectToAction("Index", "Home", productService.GetAllProducts());

            if (shopList.Contains(id))
                shopList.Remove(id);

            HttpContext.Session.Set(SessionHelper.ShoppingCart, shopList);

            return RedirectToAction("Index", "Home", productService.GetAllProducts());
        }

        [HttpPost]
        [Route("AddFavorite/{id}")]
        public IActionResult AddFavorite(int id)
        {
            var wishList = HttpContext.Session.Get<List<int>>(SessionHelper.FavoriteProducts);

            if (wishList == null)
                wishList = new List<int>();

            if (!wishList.Contains(id))
                wishList.Add(id);

            HttpContext.Session.Set(SessionHelper.FavoriteProducts, wishList);

            return RedirectToAction("Index", "Home", productService.GetAllProducts());
        }

        [HttpPost]
        [Route("RemoveFavorite/{id}")]
        public IActionResult RemoveFavorite(int id)
        {
            var wishList = HttpContext.Session.Get<List<int>>(SessionHelper.FavoriteProducts);

            if (wishList == null)
                return RedirectToAction("Index", "Home", productService.GetAllProducts());

            if (wishList.Contains(id))
                wishList.Remove(id);

            HttpContext.Session.Set(SessionHelper.FavoriteProducts, wishList);

            return RedirectToAction("Index", "Home", productService.GetAllProducts());
        }
    }
}
