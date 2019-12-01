using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson1 = new Person() { Name = "Homer", Age = 35};
            Person newPerson2 = new Person() { Name = "Liza", Age = 12 };

            Person.AddPersonToDB(newPerson1);
            Person.AddPersonToDB(newPerson2);

            Person findByName = Person.GetByName("Homer");
            if (findByName != null)
            {
                findByName.PrintPerson();
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        private static List<Person> personDB = new List<Person>();
        public string Name { get; set; }
        public int Age { get; set; }
        public static void AddPersonToDB(Person curPerson)
        {
            personDB.Add(curPerson);
        }
        public static Person GetByName(string name)
        {
            //find in DB
            Person persByName = personDB.Where(x=>x.Name==name).FirstOrDefault();
            return persByName;
        }
        public void PrintPerson()
        {
            //print data about person to the file
            Console.WriteLine($"Person name is {this.Name}, he/she is {this.Age} years old");
        }
    }
}
