using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrintedProducts.Data;
using PrintedProducts.Models;

namespace PrintedProducts.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductListing productService;

        public ProductController(IProductListing productService)
        {
            this.productService = productService;
        }

        [Route("/Product/Index",
            Name = "trays")]
        public IActionResult Index()
        {
            var model = BuildProductIndexModel("Tray");
            return View(model);
        }

        public ProductIndexModel BuildProductIndexModel(string type)
        {
            var list = productService.GetByType(type);
            var products = list.Select(p => new ProductListingModel
            {
                Id = p.Id,
                Title = p.Title,
                ShortDescription = p.ShortDescription,
                ImageUrl = p.ImageUrl,
                ImageThumbnailUrl = p.ImageThumbnailUrl,
                ProductType = p.ProductType,
                Price = p.Price
            });

            return new ProductIndexModel()
            {
                ProductList = products
            };
            
        }

    }
}