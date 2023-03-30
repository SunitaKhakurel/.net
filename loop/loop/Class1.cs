using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    public class driver : person
    {
        public string DriverLisensedNo { get; set; }
        public void Desc()
        {
            Console.WriteLine("I am a driver");
        }

    }
}
