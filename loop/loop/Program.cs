using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                person sunita = new person("sunita", 2 , 5, "black");
            
            sunita.MyDesc();


            person suman = new person("suman", 2, 6, "black");
            
            suman.MyDesc();

            //Console.WriteLine("enter your favourite color");
            //string favcolor = Console.ReadLine();
            //switch (favcolor)
            //{
            //    case "red":
            //        Console.WriteLine("you are lovely");
            //        break;
            //    case "blue":
            //        Console.WriteLine("you are peaceful");
            //        break;
            //    case " green":
            //        Console.WriteLine("you are mature");
            //        break;



            //}
            //for (int counter = 1; counter <= 10; counter++)
            //{
            //    Console.WriteLine("your loop is in" + counter + "state");
            //}

            //int counter2 = 1;
            //while (counter2 <= 10)
            //{

            //Console.WriteLine("your loop is in"+counter2+ "state");
            //    counter2 += 2;
            //}


            Console.ReadKey();
             
        }
    }
}
