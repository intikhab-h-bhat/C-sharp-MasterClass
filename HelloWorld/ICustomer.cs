using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    interface ICustomer
    {
        void GetCustomer();
        void AddCustomer();
        void DeleteCustomer();


    }

    class Customer: ICustomer
    {

        public void GetCustomer() { 

        }
        public void AddCustomer() {
        }

        public void DeleteCustomer() { }

    }
}
