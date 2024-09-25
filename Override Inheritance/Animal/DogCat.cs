using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Program_104
{
    class Abstract
    {
        public static void Main(string[] args)
        {
            string name2;
            int age2;

            Console.WriteLine("Enter the name of your dog : ");
            name2 = Console.ReadLine();
            Console.WriteLine("Enter the age of your dog  : ");
            age2 = int.Parse(Console.ReadLine());

            Animal1 a = new Dog1(name2, age2);

            Console.WriteLine("Enter the name of your dog : ");
            name2 = Console.ReadLine();
            Console.WriteLine("Enter the age of your dog  : ");
            age2 = int.Parse(Console.ReadLine());
            Animal1 b = new Cat1(name2, age2);

            a.Dogname();
            a.makesound1();
            b.Dogname();
            b.makesound1();
        }
    }
    abstract class Animal1
    {
        string name { get; set; }
        int age { get; set; }
        public Animal1(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public void Dogname()
        {
            Console.WriteLine("Name : " + " " + name);
            Console.WriteLine("Age  : " + " " + age);
        }
        public abstract void makesound1();
        public void sleep()
        {
            Console.WriteLine("Zzzzzz");
        }
    }
    class Dog1 : Animal1
    {
        public Dog1(string Name, int Age) : base(Name, Age)
        { }
        public override void makesound1()
        {
            Console.WriteLine("Arf");
        }
    }
    class Cat1 : Animal1
    {
        public Cat1(string Name, int Age) : base(Name, Age) { }
        public override void makesound1()
        {
            Console.WriteLine("Meow");
        }
    }
}
