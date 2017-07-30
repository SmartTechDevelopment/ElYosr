using ElYosr.DataLayer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElYosr.DataLayer
{
    class BlackListData
    {
        // constructor
        BlackListData()
        {
            // establishing connection
        }

        // destructor
        ~BlackListData()
        {
            // closing connection
        }

        // add to black list
        void add_to_black_list(int customer_id, string reason, DateTime block_date)
        {

        }

        // delete from black_list
        void delete_from_black_list(int customer_id)
        {

        }


        // get all customers in black_list 
        List<Customer> GetAllBlocked()
        {

        }

        // search Customer By ID
        bool search_in_black_list(int customer_id)
        {

        }

    }
}
