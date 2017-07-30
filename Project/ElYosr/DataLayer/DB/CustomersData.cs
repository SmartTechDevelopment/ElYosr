using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElYosr.DataLayer.DB;

namespace ElYosr.DataLayer
{
    class CustomersData
    {
        // constructor 
        CustomersData ()
        {
            // establishing connection
        }
        ~CustomersData()
        {
            // closing connection
        }

        
        // get customer by id 
        Customer getCustomerByID ( int Customer_ID ) 
        {

        }

        // get customer by name
        Customer getCustomerByID(string Customer_Name)
        {

        }

        // get all customers 
        List<Customer> getAllCustomers()
        {

        }

        // add new customer
        void add_customer ( Customer c )
        {

        }

        // update customer info
        void update_customer ( int customer_id , Customer new_customer )
        {

        }


    }
}
