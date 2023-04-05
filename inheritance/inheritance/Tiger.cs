using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
     internal partial class Tiger : Animal
    {
        public override void whatieat()
        {
            Console.WriteLine("This is a Tiger");
            Console.WriteLine("tiger eat flesh");
        }
    }
    internal partial  class Tiger : Animal
    {
        public void intro()
        {
            Console.WriteLine("This is a Tiger");
        }
       
    }

}
