using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person() { Name="Tom"};
            tom.Run();
            Console.WriteLine("Change action");
            tom.Walk();
            Console.ReadKey();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public void Run()
        {
            Console.WriteLine($"Im {this.Name} and Im runing");
        }
        public void Walk()
        {
            Console.WriteLine($"Im {this.Name} and Im walking");
        }
    }
}
