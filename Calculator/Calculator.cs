using System;

namespace Project_104
{
    class Project
    {
        public static void Main(string[] args)
        {
            int num1, result, add, sub, mult, div;
            string opertr, response;
            bool isValid, playAgain = true;

            do
            {
                do
                {
                    Console.WriteLine("Enter a number:");
                    isValid = int.TryParse(Console.ReadLine(), out num1);
                }
                while (isValid == false);

                do
                {
                    Console.WriteLine("Choose an operator ex. +, *, /,- ");
                    opertr = Console.ReadLine();
                    isValid = opertr == "+" || opertr == "-" || opertr == "*" || opertr == "/";
                }
                while (isValid == false);

                switch (opertr)
                {
                    case "+":
                        Console.WriteLine("How many times do you want it to be added?");
                        add = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= add; i++)
                        {
                            result = num1 + i;
                            Console.WriteLine($"{num1} + {i} = {result} ");
                        }
                        break;

                    case "-":
                        Console.WriteLine("How many times do you want it to be subtracted?");
                        sub = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= sub; i++)
                        {
                            result = num1 - i;
                            Console.WriteLine($"{num1} - {i} = {result}");
                        }
                        break;

                    case "*":
                        Console.WriteLine("How many times do you want it to be multiplied?");
                        mult = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= mult; i++)
                        {
                            result = num1 * i;
                            Console.WriteLine($"{num1} * {i} = {result}");
                        }
                        break;
                    case "/":
                        Console.WriteLine("How many times do you want it to be divided?");
                        div = Convert.ToInt32(Console.ReadLine());

                        for (int i = 1; i <= div; i++)
                        {
                            result = num1 / i;
                            Console.WriteLine($"{num1} / {i} = {result}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                Console.WriteLine("Do You Want To Calculate Again? Y/N ");
                response = Console.ReadLine().ToUpper();
                Console.Clear();

            } while (response == "Y");

            Console.WriteLine("Thank you");
            Console.ReadKey();
        }
    }
}
