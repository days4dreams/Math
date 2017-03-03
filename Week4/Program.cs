using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 10;
            double radius2 = 5;
            double calculation = 0;
            double calculation2 = 0;
            calculation = Area(radius);
            calculation2 = Circum(radius2);

            Console.WriteLine(calculation);
            Console.WriteLine(calculation2);
            Console.ReadKey();
        }
        static double Area(double r)
        {
            double area = 0;
            area = Math.PI * Math.Pow(r, 2);
            return area;
        }

        static double Circum(double r)
        {
            double c = 0;
            c = 2 * Math.PI * r;
            return c;
        }

    }
}
