//Simple program for read and write operations on console

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi user please enter any string on console");
            string input_from_user= Console.ReadLine();
            
            //bussiness logic area

            Console.WriteLine("You entered string is " + input_from_user);
            Console.ReadLine();
        }
    }
}
