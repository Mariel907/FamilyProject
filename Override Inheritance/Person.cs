using Properties;
using System.Text.RegularExpressions;
using System.Xml.Linq;

class Person
{
    private string _name;
    private int _age;   
    public string name { get; set; }
    public int age { get; set; }
    public void fatherName()
    {
        Console.WriteLine("Parent/s information");
        Console.WriteLine("Father");
        Console.WriteLine("Father name : " + " " + name);
        Console.WriteLine("Age  : " + " " + age);
    }
    public Person(string Name, int Age)
    {
        name = Name;
        age = Age;
    }
}
class Person01 : Person
{
    public Person01(string Name, int Age) : base(Name, Age) { }
    public void motherName()
    {
        Console.WriteLine();
        Console.WriteLine("Name of Mother");
        Console.WriteLine("Mother name  : " + " " + name);
        Console.WriteLine("Age          : " + " " + age);
        Console.WriteLine("- - - - - - - - - - - - - - - - - ");
    }
}
class Child01 : Person01
{
    private string _gender;
    public string gender { get; set; }
    public Child01(string Name, int Age, string Gender) : base(Name, Age)
    {
        gender = Gender;
    }
}
class Child02 : Child01
{
    private string _favegame;
    public string favegame { get; set; }
    public Child02(string Name, int Age, string Gender, string Favegame) : base(Name, Age, Gender)
    {
        favegame = Favegame;
    }
    public void student()
    {
        Console.WriteLine();
        Console.WriteLine("Student Family");
        Console.WriteLine("Name of student: " + " " + name);
        Console.WriteLine("Age            : " + " " + age);
        Console.WriteLine("Gender         : " + " " + gender);
        Console.WriteLine("Favorite game  : " + " " + favegame);
        Console.WriteLine("- - - - - - - - - - - - - - - - - ");
    }
}
