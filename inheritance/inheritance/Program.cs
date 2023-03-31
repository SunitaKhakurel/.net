using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            polymorphism poly = new polymorphism();
            poly.whoami();
            poly.whoami("sunita");
            poly.whoami(34);
            Tiger tiger = new Tiger();
            tiger.whatieat();
            tiger.whatibreathe();
            lion lion = new lion();
            lion.whatibreathe1();
            lion.whatieat1();
            Console.ReadKey();   
        }
    }
}
