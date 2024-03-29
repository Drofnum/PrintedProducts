﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintedProducts.Models
{
    public class ProductListingModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string ProductType { get; set; }
        public string LongDescription { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public int QuantityAvailable { get; set; }
        public bool IsInStock { get; set; }
    }
}
