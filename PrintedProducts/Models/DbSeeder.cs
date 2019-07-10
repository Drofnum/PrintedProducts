using PrintedProducts.Data;
using PrintedProducts.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintedProducts.Models
{
    public static class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Products.Any())
            {
                context.AddRange
                    (
                        new Products { Title = "Library of Ithilia", ShortDescription = "Library of Ithilia terrain piece", ImageUrl = "/images/LibraryOfIthilia.jpg", Price = 25.00M, ProductType = "Terrain", ImageThumbnailUrl = "/images/LibraryOfIthiliaThumb.jpg", IsInStock = true, LongDescription = "Library of Ithilia terrain piece, HUGE Elven tree library", QuantityAvailable = 24 },
                        new Products { Title = "Ithilia Skyport", ShortDescription = "Ithilia Skyport terrain piece", ImageUrl = "/images/IthillianSkyPort.jpg", Price = 20.00M, ProductType = "Terrain", ImageThumbnailUrl = "/images/IthillianSkyPortThumb.jpg", IsInStock = true, LongDescription = "Ithilia Skyport terrain piece, dock your skyships here!", QuantityAvailable = 24 },
                        new Products { Title = "Ironhelm Fortress", ShortDescription = "Ironhelm Fortress terrain piece", ImageUrl = "/images/IronhelmFortress.jpg", Price = 35.00M, ProductType = "Terrain", ImageThumbnailUrl = "/images/IronhelmFortressThumb.jpg", IsInStock = true, LongDescription = "Ironhelm Fortress terrain piece, dwarves love it!", QuantityAvailable = 24 },
                        new Products { Title = "25mm Line", ShortDescription = "25mm movement tray in line configuration", ImageUrl = "/images/Trays.jpg", Price = 2.00M, ProductType = "Tray", ImageThumbnailUrl = "/images/TraysThumb.jpg", IsInStock = true, LongDescription = "25mm movement tray in line configuration", QuantityAvailable = 24 },
                        new Products { Title = "32mm Line", ShortDescription = "32mm movement tray in line configuration", ImageUrl = "/images/Trays.jpg", Price = 2.50M, ProductType = "Tray", ImageThumbnailUrl = "/images/TraysThumb.jpg", IsInStock = true, LongDescription = "32mm movement tray in line configuration", QuantityAvailable = 24 },
                        new Products { Title = "25mm Cloud", ShortDescription = "25mm movement tray in cloud configuration", ImageUrl = "/images/25Cloud.jpg", Price = 2.00M, ProductType = "Tray", ImageThumbnailUrl = "/images/25CloudThumb.jpg", IsInStock = true, LongDescription = "25mm movement tray in cloud configuration", QuantityAvailable = 24 },
                        new Products { Title = "32mm Cloud", ShortDescription = "32mm movement tray in cloud configuration", ImageUrl = "/images/Trays.jpg", Price = 2.50M, ProductType = "Tray", ImageThumbnailUrl = "/images/TraysThumb.jpg", IsInStock = true, LongDescription = "32mm movement tray in cloud configuration", QuantityAvailable = 24 }
                    );
            }
            context.SaveChanges();
        }
    }
}
