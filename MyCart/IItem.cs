using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRestaurant
{
    public interface IItem
    {
        string Name { get; }
        int Price { get; }
    }
}
