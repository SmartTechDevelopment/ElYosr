using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElYosr.DataLayer
{
    class UsersData
    {

        UsersData()
        {
            // establishing connection 
        }
        ~UsersData()
        {
            // closing connection 
        }
        
        // check users data 
        bool verify(string username, string password)
        {

        }

        // add user
        void add_user(string username, string password)
        {

        }

        // change user password 
        void update_password(string username, string old_password, string new_password)
        {

        }

        // change username 
        void update_username(string old_username, string password, string new_username)
        {

        }


    }
}
