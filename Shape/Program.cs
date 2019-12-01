using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle newRect = new Rectangle();
            List<Point> listOfTops = new List<Point>() { new Point(0, 0), new Point(0, 2), new Point(2, 2), new Point(2, 0) };
            newRect.Tops = listOfTops;
            //it has no sence
            newRect.Center = new Point(1, 1);

            Circle newCircle = new Circle();
            //it has no sence
            newCircle.Tops = listOfTops;
            newCircle.Center = new Point(0, 0);
            Console.ReadKey();
        }
    }
    public class Shape
    {
        public double GetSquare()
        {
            return 0;
        }
        public double GetPerimeter()
        {
            return 0;
        }
        public Point Center { get; set; }
        public List<Point> Tops { get; set; }
    }
    public class Rectangle : Shape
    {
    }
    public class Circle : Shape
    {
    }

}
