using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCart
{
    public class Meat : IItem
    {
        public string Name { get; set; }

        public Meat(string name) 
        {
            this.Name = name;
        }
    }

    public class Fruit : IItem
    {
        public string Name { get; set; }

        public Fruit(string name)
        {
            this.Name = name;
        }
    }
}
