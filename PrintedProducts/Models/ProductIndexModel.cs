using PrintedProducts.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintedProducts.Models
{
    public class ProductIndexModel
    {
        public string Title { get; set; }
        public string ProductType { get; set; }

        public IEnumerable<ProductListingModel> ProductList { get; set; }
    }
}
