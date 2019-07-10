using PrintedProducts.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedProducts.Data
{
    public interface ITray
    {
        Trays GetById(int id);
        IEnumerable<Trays> GetAll();
    }
}
