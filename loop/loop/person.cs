using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
     public class person
    {

        public string name { get; set; }
        public int nooftypes { get; set; }
        public int height { get; set; }
        public string facecolor { get; set; }
        public void Lunch()
        {
            Console.WriteLine("I usually have mango in lunch");

        }

        public void MYColor()
        {
            Console.WriteLine("mY face color is" + facecolor);
        }


        public person(string Name, int NoOfEyes, int Height, string FaceColor)
        {
            name = Name;
            nooftypes = NoOfEyes;
            height = Height;
            facecolor = FaceColor;

        }
        public person() { }

        public virtual void Desc()
        {
           
            Console.WriteLine("my name is " + name);
            Console.WriteLine("I have " + nooftypes + " eyes");
            Console.WriteLine("my face color is " + facecolor);
            Console.WriteLine("i am " + height + " feet tall");

        }
        ~person() { }
       

    }
    
}
