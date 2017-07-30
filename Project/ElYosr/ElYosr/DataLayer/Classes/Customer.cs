using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElYosr.DataLayer.DB
{
    class Customer
    {
        private int customer_ID;

        public int Customer_ID
        {
            get { return customer_ID; }
            set { customer_ID = value; }
        }

        private string customer_Name;

        public string Customer_Name
        {
            get { return customer_Name; }
            set { customer_Name = value; }
        }

        private string customer_Phone_1;

        public string Customer_Phone_1
        {
            get { return customer_Phone_1; }
            set { customer_Phone_1 = value; }
        }

        private string customer_Phone_2;

        public string Customer_Phone_2
        {
            get { return customer_Phone_2; }
            set { customer_Phone_2 = value; }
        }

        private string customer_Home;

        public string Customer_Home
        {
            get { return customer_Home; }
            set { customer_Home = value; }
        }

        private string customer_Work;

        public string Customer_Work
        {
            get { return customer_Work; }
            set { customer_Work = value; }
        }
        

    }
}
