using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElYosr.DataLayer
{
    class Bill
    {        
        private int transaction_ID , delegate_ID, customer_ID;
        private double price;
        private string transaction_Date;
        private List<int> products_IDs;


        public int Transaction_ID
        {
            get { return transaction_ID; }
            set { transaction_ID = value; }
        }

        public int Delegate_ID
        {
            get { return delegate_ID; }
            set { delegate_ID = value; }
        }

        public int Customer_ID
        {
            get { return customer_ID; }
            set { customer_ID = value; }
        }

        public string Transaction_Date
        {
            get { return transaction_Date; }
            set { transaction_Date = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public List<int> Products_IDs
        {
            get { return products_IDs; }
            set { products_IDs = value; }
        }


        
    }
}
