using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElYosr.DataLayer
{
    class Product
    {
        private int product_ID;

        public int Product_ID
        {
            get { return product_ID; }
            set { product_ID = value; }
        }

        private int product_Cat_ID;

        public int Product_Cat_ID
        {
            get { return product_Cat_ID; }
            set { product_Cat_ID = value; }
        }

        private string product_Name;

        public string Product_Name
        {
            get { return product_Name; }
            set { product_Name = value; }
        }

        private double product_Price_Cash;

        public double Product_Price_Cash
        {
            get { return product_Price_Cash; }
            set { product_Price_Cash = value; }
        }

        private double product_Price_Install;

        public double Product_Price_Install
        {
            get { return product_Price_Install; }
            set { product_Price_Install = value; }
        }

        private int product_Quantity;

        public int Product_Quantity
        {
            get { return product_Quantity; }
            set { product_Quantity = value; }
        }

    }
}
