using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRestaurant
{
    public interface IRestaurant
    {
        string Name { get; }
        List<IItem> Menu { get; }
    }
}
