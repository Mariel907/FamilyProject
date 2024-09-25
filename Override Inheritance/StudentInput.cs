using Properties;
using System;

namespace inherit
{
    class Inheritance
    {
        public static void Main(string[] args)
        {
            string name1, gender1, fave, response;
            int age1;
            int sibNum;
            bool isValid = false ;

            List<Child01> children = new List<Child01>();

            do
            {
                name1 = Helper.GetName("Enter your name : ");
                age1 = Helper.GetNum("Enter your age : ");
                gender1 = Helper.GetGender("Enter your gender : ");
                Console.Write("Enter your favorite game : ");
                fave = Console.ReadLine();
                Console.WriteLine();
            
                Child02 b = new Child02(name1, age1, gender1, fave);

                sibNum = Helper.GetNum("How many sibling/s do you have ? : ");
                Child01 sib1 = new Child01(name1, age1, gender1);

                for (int i = 0; i < sibNum; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Enter the information of your sibling/s {i + 1}:");
                    name1 = Helper.GetName($"Sibling name no.   {i + 1}: ");
                    age1 = Helper.GetNum($"Sibling age no.    {i + 1}: ");
                    gender1 = Helper.GetGender($"Sibling gender no. {i + 1}: ");

                    Child01 sibling = new Child01(name1, age1, gender1);
                    children.Add(sibling);
                }

                name1 = Helper.GetName("Enter your Father name  : ");
                age1 = Helper.GetNum("Father age              : ");
                Person c = new Person(name1, age1);

                name1 = Helper.GetName("Enter your Mother name : ");
                age1 = Helper.GetNum("Mother age             : ");
                Console.WriteLine();
                Person01 d = new Person01(name1, age1);

                b.student();
                Console.WriteLine("\nSibling/s Information");
                foreach (var item in children)
                {
                    Console.WriteLine($"Name: {item.name}\nAge: {item.age}\nGender: {item.gender}\n");
                }
                Console.WriteLine("- - - - - - - - - - - - - - - - - ");

                c.fatherName();
                d.motherName();
                children.Clear();

                Console.WriteLine("Do You Want To Input Again? Y/N ");
                response = Console.ReadLine().ToUpper();
                Console.Clear();

            } while (response == "Y");
        }
    }
}
