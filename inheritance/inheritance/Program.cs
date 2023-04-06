using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        public delegate void function1caller();
        static void Main(string[] args)
        {
            //    //POLYMORPHISM
            //    polymorphism poly = new polymorphism();
            //    poly.whoami();
            //    poly.whoami("sunita");
            //    poly.whoami(34);
            //    Tiger tiger = new Tiger();
            //    tiger.whatieat();
            //    tiger.whatibreathe();
            //    lion lion = new lion();
            //    lion.whatibreathe1();
            //    lion.whatieat1();

            //    try
            //    {
            //    //stack overflow exception
            //    string[] names = new string[5];
            //    names[0] = "sunita";
            //    names[5] = "suman";
            //    //conversion excepton
            //    string mynumber = Console.ReadLine();

            //    int rollno = Convert.ToInt32(mynumber);
            //    Console.WriteLine("my roll no is "+rollno);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception occur of type " + ex.Message);
            //}
            //lab 7
            //MyFunction1();
            //MyFunction2();
            //defining deligate
            function1caller fn = new function1caller(MyFunction1);
            fn += MyFunction2;
           // function1caller fn1 = new function1caller(MyFunction2);
            fn();
            //fn1();
            Console.ReadKey();
        }
        public static void MyFunction1()
        {
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine("i am function 1");

            }

        }
        public static async void MyFunction2()
        {
            await Task.Run(() =>
             {
                 for (int counter = 1; counter <= 10; counter++)
                 {
                     Console.WriteLine("i am function 2");
                 }
             });

        }
    }
}
