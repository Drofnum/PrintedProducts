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

        public IActionResult Index(int id)
        {
            if (id == 1)
            {
                var model = BuildProductIndexModel("Tray");
                return View(model);
            }
            else if (id == 2)
            {
                var model = BuildProductIndexModel("Terrain");
                return View(model);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Detail(int id)
        {
            var product = productService.GetById(id);

            var model = new ProductListingModel
            {
                Id = product.Id,
                Title = product.Title,
                LongDescription = product.LongDescription,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                QuantityAvailable = product.QuantityAvailable,
                IsInStock = product.IsInStock
            };

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