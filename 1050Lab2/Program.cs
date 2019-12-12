using System;

namespace _1050Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter information for person 1: ");

            Person person1 = new Person();
            person1.AskUserForNameAndAge();
            person1.CreateSpouseIfMarried();

            Console.WriteLine("Enter information for person 2: ");

            Person person2 = new Person();
            person2.AskUserForNameAndAge();
            person2.CreateSpouseIfMarried();

            Person spouse1 = new Spouse();
            spouse1.AskUserForNameAndAge();
            spouse1.CreateSpouseIfMarried();

            Person spouse2 = new Spouse();
            spouse2.AskUserForNameAndAge();
            spouse2.CreateSpouseIfMarried();

            System.Console.WriteLine("Average Age: " + Person.AverageAge());
            System.Console.ReadKey();
        }
    }
}
