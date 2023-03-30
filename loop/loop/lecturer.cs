using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
   public class lecturer: person 
    {
        public string Degree { get; set; }
        public void desc()
        {
            Console.WriteLine("i am lecturer");
            
        }
        public lecturer(string Name, int NoOfEyes, int Height, string FaceColor) : base(Name, NoOfEyes, Height, FaceColor)
        {
        
        }
    }
}
