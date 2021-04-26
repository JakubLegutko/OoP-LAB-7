using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_LAB_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
           
            Simulator newsim = new Simulator();
            
            Console.WriteLine("To move use W A S D, they correspond to North, West, South and East, to delete use backspace and to confirm moves use Enter");
            
            newsim.Memorize();
            Console.WriteLine("done");
        }
    }
}
