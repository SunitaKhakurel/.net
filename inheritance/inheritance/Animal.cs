using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    abstract class Animal
    {

        public abstract void whatieat();
        public void whatibreathe()
        {
            Console.WriteLine("We breathe oxygen");
        }
        
    }

    public interface Animal2
    {
       void whatieat1();
        void whatibreathe1();
    }
     class lion : Animal2
    {
        public void whatieat1()
        {
            Console.WriteLine("Lion eat flesh");

        }
        public void whatibreathe1()
        {
            Console.WriteLine("Lion also breath oxygen");
        }

    }


}
