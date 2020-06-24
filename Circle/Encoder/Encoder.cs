using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoder
{
    class Encoder
    {
        public void decode(int number)
        {
            if (number >= 32 && number < 126)
            {
                Console.WriteLine((char)number);
            }
            else
            {
                Console.WriteLine("From 32 to 126.");
            }
        }

        public void encode(char symbol)
        {
            Console.WriteLine((int)symbol);
        }
    }
}
