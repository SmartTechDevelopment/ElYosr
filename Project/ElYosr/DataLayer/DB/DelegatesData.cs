using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElYosr.DataLayer.DB;

namespace ElYosr.DataLayer
{
    class DelegatesData
    {
        // constructor
        DelegatesData()
        {
            // establishing connection
        }

        // destructor
        ~DelegatesData()
        {
            // closing connection
        }


        // get delegate by name
        int getDelegateIDByName(string delegate_name)
        {

        }

        // add new delegate 
        void add_delegate(Delegator del)
        {

        }

        // delete delegate 
        void delete_delegate(int delegate_ID)
        {

        }

        // update delegate info 
        void update_cat(int delegate_ID, Delegator new_del)
        {

        }


        // get all delegates
        List<Delegator> getAllDelegates()
        {

        }

    }
}
