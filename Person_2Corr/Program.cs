using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_2Corr
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person(new WalkingMovement()) { Name="Tom"};
            tom.MoveAction();
            Console.WriteLine("Switch action");
            tom.MoveType = new RunningMovement();
            tom.MoveAction();
            Console.ReadKey();
        }
    }
    class Person
    {
        public Person(IMove moveType)
        {
           this.MoveType= moveType;
        }
        public void MoveAction()
        {
            MoveType.Move(this.Name);      
        }
        public string Name { get; set; }
        public IMove MoveType{get;set;}
    }
    public interface IMove
    {
        void Move(string whoMove);
    }
    class RunningMovement : IMove
    {
        public void Move(string whoMove)
        {
            Console.WriteLine($"Im {whoMove} and Im runing");
        }

    }
    class WalkingMovement : IMove
    {
        public void Move(string whoMove)
        {
            Console.WriteLine($"Im {whoMove} and Im walking");
        }
    }
}
