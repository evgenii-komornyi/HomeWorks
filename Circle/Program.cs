using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.radius = 5.0;
            Console.WriteLine(circle.printResult());
        }
    }
}
