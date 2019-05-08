using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCart
{
    public partial class Form1 : Form
    {

        ICart cartMeat = new CartMeat();
        ICart cartFruit = new CartFruit();

        public Form1() => InitializeComponent();

        private void Meat_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            IItem item = new Meat(btn.Text);
            cartMeat.AddCart(item);
            ShowCrat(labelMeat, cartMeat.GetCartText);
        }

        private void Fruit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            IItem item = new Fruit(btn.Text);
            cartFruit.AddCart(item);
            ShowCrat(labelFruit, cartFruit.GetCartText);
        }

        private void 結帳_Click(object sender, EventArgs e)
        {
            ShowTotalPrice(cartMeat, cartMeat, cartMeat.GetTotlePriceText, cartFruit.GetTotlePriceText);
        }

        public void ShowCrat(Label label, Func<string> getcarttext)
        {
            label.Text = getcarttext();
        }

        public void ShowTotalPrice(ICart cartmeat, ICart cartfruit, Func<string> getmeatcartpricetext, Func<string> getfruitcartpricetext)
        {


            labelTotalPrice.Text = $"{getmeatcartpricetext()}{getfruitcartpricetext()}";
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            labelMeat.Text = "";
            labelFruit.Text = "";
            labelTotalPrice.Text = "";
            cartMeat.ClearCart();
            cartFruit.ClearCart();
        }
    }
}
