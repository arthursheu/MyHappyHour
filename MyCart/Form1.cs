using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyRestaurant
{
    public partial class Form1 : Form
    {
        IRestaurant myRestaurant = new Restaurant();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void 排骨飯_Click(object sender, EventArgs e)
        {
            IItem item = new Item(((Button)sender).Text, int.Parse(排骨飯價錢.Text));
            myRestaurant.Menu.Add(item);
        }

        public void ShowMenu() 
        {
            foreach (IItem item in myRestaurant.Menu) 
            {
                餐廳1菜單.Text += string.Format("{0} {1}元\r\n",item.Name,item.Price);
            }
        }
    }
}
