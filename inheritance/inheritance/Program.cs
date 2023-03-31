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
            
            try
            {
                //stack overflow exception
                string[] names = new string[5];
                names[0] = "sunita";
                names[5] = "suman";
                //conversion excepton
                string mynumber = Console.ReadLine();

                int rollno = Convert.ToInt32(mynumber);
                Console.WriteLine("my roll no is "+rollno);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occur of type " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
