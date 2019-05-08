using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCart
{
    public class CartMeat : ICart
    {
        public double TotalPrice { get; set; }
        public int HasDiscountQuantity { get; set; }
        public List<IItem> CartItems { get; set; }

        public CartMeat()
        {
            this.CartItems = new List<IItem>();
            this.HasDiscountQuantity = 3;
        }

        public void AddCart(IItem item)
        {
            this.CartItems.Add(item);
        }

        public string GetCartText()
        {
            string carttext = "";
            foreach (IItem item in this.CartItems)
            {
                carttext += $"{item.Name}x1 \r\n";
            }

            return carttext;
        }

        public string GetTotlePriceText()
        {
            string t = "";
            if (this.CartItems.Count > 0)
            {
                t = $"共購買{this.CartItems.Count}樣肉品";
                if (this.CartItems.Count >= this.HasDiscountQuantity)
                {
                    t += $"，{this.HasDiscountQuantity}樣以上8折\r\n";
                }
                else
                {
                    t += $"\r\n";
                }
            }
            else
            {
                t = $"你沒買肉品 \r\n";
            }

            return t;
        }

        public void ClearCart()
        {
            this.CartItems.Clear();
        }
    }


    public class CartFruit : ICart
    {
        public double TotalPrice { get; set; }
        public int HasDiscountQuantity { get; set; }
        public List<IItem> CartItems { get; set; }

        public CartFruit()
        {
            this.CartItems = new List<IItem>();
            this.HasDiscountQuantity = 5;
        }

        public void AddCart(IItem item)
        {
            this.CartItems.Add(item);
        }

        public string GetCartText()
        {
            string carttext = "";
            foreach (IItem item in this.CartItems)
            {
                carttext += $"{item.Name}x1 \r\n";
            }

            return carttext;
        }

        public string GetTotlePriceText()
        {
            string t = "";
            if (this.CartItems.Count > 0)
            {
                t = $"共購買{this.CartItems.Count}樣水果";
                if (this.CartItems.Count >= this.HasDiscountQuantity)
                {
                    t += $"，{this.HasDiscountQuantity}樣以上7折\r\n";
                }
                else
                {
                    t += $"\r\n";
                }
            }
            else
            {
                t = $"你沒買水果 \r\n";
            }

            return t;
        }

        public void ClearCart()
        {
            this.CartItems.Clear();
        }
    }
}
