using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class AbstractionDemo
    {

        public void SendEmail()
        {
            Connet();
            Authenticate();
            Console.WriteLine("Send Email");
           CloseConnection();

        }
        private void Connet()
        {
            Console.WriteLine("Connext to Server");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticate");
        }

        private void CloseConnection()
        {
            Console.WriteLine("Closed");
        }


    }
}
