using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ElYosr.DataLayer.DB
{
    class Delegator
    {
        private int del_ID;

        public int Delegate_ID
        {
            get { return del_ID; }
            set { del_ID = value; }
        }

        private string del_Name;

        public string Delegate_Name
        {
            get { return del_Name; }
            set { del_Name = value; }
        }


        private string del_Phone;

        public string Delegate_Phone
        {
            get { return del_Phone; }
            set { del_Phone = value; }
        }

        private string del_Address;

        public string Delegate_Address
        {
            get { return del_Address; }
            set { del_Address = value; }
        }
        


    }
}
