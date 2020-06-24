using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        public double radius { get; set; }

        public double carculateArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public string printResult()
        {
            return "Area with radius " + radius + " sm is " + carculateArea() + " sm.";
        }
    }
}
