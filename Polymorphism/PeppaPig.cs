using System;

namespace Poly
{
    class Polymorphism
    {
        public static void Main(string[] args)
        {
            string name1;

            DaddyPig a = new DaddyPig();
            a.dadPig();

            Console.WriteLine();
            Console.Write("Enter your name : ");
            name1 = Console.ReadLine();
            Console.WriteLine();

            DaddyPig b = new PeppaPig(name1);
            b.dadPig();
            DaddyPig c = new MommyPig();
            c.dadPig();
        }
    }
    class DaddyPig
    {
        virtual public void dadPig()
        {
            Console.WriteLine("Hi I'm daddy pig");
        }
    }
    class PeppaPig : DaddyPig
    {
        public string name { get; set; }
        public PeppaPig(string Name)
        {
            name = Name;
        }
        override public void dadPig()
        {
            Console.WriteLine("I'm Peppa Pig and this is" + " " + name);
        }
    }
    class MommyPig : DaddyPig
    {
        override public void dadPig()
        {
            Console.WriteLine("and I'm mommy pig.");
        }
    }
}
