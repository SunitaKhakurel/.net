using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class polymorphism
    {
        public void whoami()
        {
            Console.WriteLine("I am empty function");

        }
        public void whoami(string name)
        {
            Console.WriteLine("i am " + name);
        }
        public void whoami(int myROllnumber)
        {
            Console.WriteLine("My role number is " + myROllnumber);
        }
    }
}
