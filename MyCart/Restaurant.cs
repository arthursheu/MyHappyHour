using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRestaurant
{
    public class Restaurant : IRestaurant
    {
        public string Name { get; set; }
        public List<IItem> Menu { get; set; }
        
    }
}
