using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace file_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //writing in file
            //StreamWriter sw = new StreamWriter("Nist.txt");
            //sw.WriteLine("we are learning c#");
            //sw.WriteLine("we are leraning filehandling");
            //sw.Close();
            //reading file
            //StreamReader sr = new StreamReader("Nist.txt");
            //String line = sr.ReadLine();
            //while (line != null)
            //{
            //    Console.WriteLine(line);
            //    line = sr.ReadLine();
            //}
            ArrayList al = new ArrayList();
            al.Add("sunita");
            al.Add(23);
            al.Add(true);
            List<string> list = new List<string>();   
            list.Add("hello");
            list.Add("sunita");
            Console.ReadKey();
        }
    }
}
