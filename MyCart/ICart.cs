using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCart
{
    public interface ICart
    {
        double TotalPrice { get; }
        int HasDiscountQuantity { get; }
        List<IItem> CartItems { get; }

        void AddCart(IItem item);
        void ClearCart();
        string GetCartText();
        string GetTotlePriceText();
    }
}
