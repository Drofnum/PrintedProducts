using PrintedProducts.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintedProducts.Data
{
    public interface ITerrain
    {
        Terrain GetById(int id);

        IEnumerable<Terrain> GetAll();
    }
}
