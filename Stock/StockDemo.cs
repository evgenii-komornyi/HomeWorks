using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class StockDemo
    {
        static void Main(string[] args)
        {
            Stock google = new Stock("Google", 10);

            google.printInformation();
        }
    }
}
