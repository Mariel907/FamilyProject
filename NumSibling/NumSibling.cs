using System;
using System.Collections.Immutable;

namespace Project_Program_104
{
    internal class MethodParameters_101
    {
        public static void Main(string[] args)
        {
            string name;
            Console.Write("Enter your Name: ");
            name = Console.ReadLine();
            Console.Write("How many is/are your sibling/siblings?: ");
            numSibling(int.Parse(Console.ReadLine()));
        }
        static int numSibling(int n)
        {
            string[] sib = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the name of sibling {i + 1}: ");
                sib[i] = Console.ReadLine();
            }

            if (n == 0)
            {
                Console.WriteLine("ohh, you are the only child. Ok");
            }
            return n;
        }
    }
}
