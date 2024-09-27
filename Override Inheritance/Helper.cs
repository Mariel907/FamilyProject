using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Properties
{
    public static class Helper
    {
        public static bool IsValidName(string name)
        {
           
            bool isValid = false;
            try
            {
                isValid = !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
            }
            catch { isValid = false; }
            return isValid;
        }
        public static int GetNum(string prompt, bool canBeNegative = false)
        {
            int num = 0;
            bool isValid = true;
            do
            {
                Console.Write(prompt);
                isValid = int.TryParse(Console.ReadLine(), out num);
                if (!canBeNegative && num <= 0 )
                {
                    Console.WriteLine("Age must not be a non-negative number.");
                    isValid = false;
                }
                else if (num > 99)
                {
                    Console.WriteLine("Age must not be greater than 99.");
                    isValid = false;
                }
            } while (!isValid);
            return num;

        }
        public static int GetNumSib(string prompt, bool canBeNegative = false)
        {
            int num = 0;
            bool isValid = false;
            do
            {
                Console.Write(prompt);
                isValid = int.TryParse(Console.ReadLine(), out num);
                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
                else if (!canBeNegative && num < 0)
                {
                    Console.WriteLine("Age must not be a non-negative number.");
                    isValid = false;
                }
                else if (num > 25)
                {
                    Console.WriteLine("Age must not be greater than 25.");
                    isValid = false;
                }
            } while (!isValid);
            return num;
        }
        public static string GetName(string prompt)
        { 
            bool isValid = false;
            string name1;
            do
            {
                Console.Write(prompt);
                name1 = Console.ReadLine();
                if (Helper.IsValidName(name1))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid name. Please enter a name containing only letters and spaces.");
                }
            } while (!isValid);
            return name1;
        }
        public static string GetGender(string prompt)
        {
            bool isValid = false;
            string gender1;
            do
            {
                Console.Write(prompt);
                gender1 = Console.ReadLine().ToUpper();
                if ( gender1 == "M" || gender1 == "F")
                {
                    isValid = true;
                }
                else 
                {
                    Console.WriteLine("Invalid input. Please enter 'F' or 'M'.");
                    isValid = false;
                }
            } while (!isValid);
            return gender1;
        }
    }
}
