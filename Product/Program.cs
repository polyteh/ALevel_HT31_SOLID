using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson1 = new Person() { Name = "Homer", Age = 35 };
            PersonDB.AddPersonToDB(newPerson1);

            Person findByName = PersonDB.GetByName("Homer");
            if (findByName != null)
            {
                Printer myPrinter = new Printer();
                myPrinter.PrintPerson(findByName);
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public static class PersonDB
    {
        private static List<Person> personDB = new List<Person>();
        public static void AddPersonToDB(Person curPerson)
        {
            personDB.Add(curPerson);
        }
        public static Person GetByName(string name)
        {
            //find in DB
            Person persByName = personDB.Where(x => x.Name == name).FirstOrDefault();
            return persByName;
        }
    }
    public class Printer
    {
        public void PrintPerson(Person curPers)
        {
            //print data about person to the file
            Console.WriteLine($"Person name is {curPers.Name}, he/she is {curPers.Age} years old");
        }
    }
}

