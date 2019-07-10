using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrintedProducts.Data;
using PrintedProducts.Models;

namespace PrintedProducts.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductListing productService;

        public HomeController(IProductListing productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            var model = BuildHomeViewModel();
            return View(model);
        }

        public HomeViewModel BuildHomeViewModel()
        {
            var list = productService.GetAll();
            var products = list.Select(product => new ProductListingModel
            {
                Id = product.Id,
                Title = product.Title,
                ShortDescription = product.ShortDescription,
                ImageUrl = product.ImageUrl,
                ImageThumbnailUrl = product.ImageThumbnailUrl,
                ProductType = product.ProductType,
                Price = product.Price
            });

            return new HomeViewModel()
            {
                ProductList = products
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
