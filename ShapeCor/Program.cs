using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeCor
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle newRect = new Rectangle();
            List<Point> listOfTops = new List<Point>() { new Point(0, 0), new Point(0, 2), new Point(2, 2), new Point(2, 0) };
            newRect.Tops = listOfTops;

            Circle newCircle = new Circle();
            newCircle.Center = new Point(0, 0);
            Console.ReadKey();

        }
    }
    public class Polyhedron : IShapeProperties
    {
        public double GetSquare()
        {
            return 0;
        }
        public double GetPerimeter()
        {
            return 0;
        }
        public List<Point> Tops { get; set; }
    }
    public class Rectangle : Polyhedron
    {
    }
    public class Circle : IShapeProperties
    {
        public double GetPerimeter()
        {
            return 0;
        }
        public double GetSquare()
        {
            return 0;
        }
        public Point Center { get; set; }
    }
    public interface IShapeProperties
    {
        double GetSquare();
        double GetPerimeter();
    }
}
