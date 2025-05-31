using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Employee
    {

        public string Name { get; set; }
        public string Address { get; set; }

        public virtual void SendEmail() {

            Console.WriteLine("From Employee class");
        }

     
    }

    class Manager : Employee
    {
        public string Designation { get; set; }

        public override void SendEmail()
        {
            Console.WriteLine("From Manager Class");
        }

    }


    class Supervisor : Employee
    {
        public string Role { get; set; }


        public override void SendEmail()
        {
            Console.WriteLine("From Supervisor Class");
        }
    }

    }
