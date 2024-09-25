
using Construcor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Program_104
{
    internal class main
    {
        public static void Main(string[] args)
        {
            string name1; int age1;

            Person a = new Person("Mariel", 18);
            Person b = new Person("Jonnyl", 23);
            Person c;
            c = Person.GetPerson("Nathaniel");

            Console.WriteLine("Enter Name: ");
            name1 = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            age1 = int.Parse(Console.ReadLine());
            Person d = Person.GetPerson(name1, age1);

            a.IntroduceSelf();
            b.IntroduceSelf();
            c.IntroduceSelf();
            d.IntroduceSelf();

        }
    }
}
