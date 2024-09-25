using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Program_104
{
    internal class MethodProject101
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to enter?:");
            number(Convert.ToInt32(Console.ReadLine()));
        }
        static int number(int x)
        {
            int[] num1 = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write($"Enter number {i + 1} :");
                num1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The following numbers are");

            foreach (var j in num1)
            {
                if (j % 2 == 0)
                    Console.WriteLine($"{j} is Even");
                else
                    Console.WriteLine($"{j} is Odd");
            }
            return x;
        }
    }
}
