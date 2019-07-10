using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedProducts.Data.Models
{
    public class Terrain
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public int QuantityAvailable { get; set; }
        public bool IsInStock { get; set; }
    }
}
