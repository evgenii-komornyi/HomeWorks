using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class Stock
    {
        public String companyName { get; set; }
        public Decimal currentPrice { get; set; }
        public Decimal minPrice { get; set; }
        public Decimal maxPrice { get; set; }

        public Stock(string companyName, decimal currentPrice)
        {
            this.companyName = companyName;
            this.currentPrice = currentPrice;
            this.minPrice = currentPrice;
            this.maxPrice = currentPrice;
        }

        public Decimal updatePrice(Decimal newPrice)
        {
            this.currentPrice = newPrice;
            if (newPrice < minPrice)
            {
                minPrice = newPrice;
            }

            if (newPrice > maxPrice)
            {
                maxPrice = newPrice;
            }
            return newPrice;
        }

        public void printInformation()
        {
            Console.WriteLine($"Company: {companyName}, Current price: {currentPrice}, Min Price: {minPrice}, Max Price: {maxPrice}.");
        }
    }
}
