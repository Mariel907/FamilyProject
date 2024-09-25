using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Program_104
{
    internal class MethodProject
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter a number> ");
            oddeveNumbers(Convert.ToInt32(Console.ReadLine()));
        }
        static int oddeveNumbers(int x)
        {
            if (x % 2 == 0)
                Console.WriteLine("You entered an Even Number!");
            else
                Console.WriteLine("You entered an Odd Number!");
            return x;
        }
    }
}
