using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //start test class
    public class Circle
    {
        private const double pi = (22 / 7);
        public double Radius { get; set; }
        public Circle()
        {
  //          Console.WriteLine("Instantiated new Circle()");
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return pi * (Radius * Radius);
        }
        public double GetPerimeter()
        {
            return 2 * pi * Radius;
        }
    }
}
