using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_2Corr
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle newRect = new Rectangle();
            List<Point> listOfTops = new List<Point>() { new Point(0, 0), new Point(0, 2), new Point(2, 2), new Point(2, 0) };
            newRect.Tops = listOfTops;


            Circle newCircle = new Circle();
            //now it is error
            // newCircle.Tops = listOfTops;
            Console.ReadKey();
        }
    }
    public class Polyhedron : IShapeProperties, IPolyhedron
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
    public interface IPolyhedron
    {
        List<Point> Tops { get; set; }
    }
}
