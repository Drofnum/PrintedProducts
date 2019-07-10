using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedProducts.Data
{
    public interface IProductListing
    {
        Models.Products GetById(int id);
        IEnumerable<Models.Products> GetByType(string type);
        IEnumerable<Models.Products> GetAll();


    }
}
