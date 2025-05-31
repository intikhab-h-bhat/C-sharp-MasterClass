using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
     abstract class AbstractDemo
    {

        public string Name { get; set; }
        public string Address { get; set; }

        public abstract void SendEmail();
       

    }


    class DemoClass : AbstractDemo
    {

        public override void SendEmail()
        {
            
        }

    }
}
