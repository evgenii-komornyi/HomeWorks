using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        private string productName;
        private Decimal regularPrice;
        private Decimal discount;
        private Decimal priceWithDiscount;
        private Decimal actualPrice;

        public Product(string productName, Decimal regularPrice, Decimal discount)
        {
            this.productName = productName;
            this.regularPrice = regularPrice;
            this.discount = discount;
        }

        public void printOutTheInformation()
        {
            priceWithDiscount = (Decimal.Multiply(this.regularPrice, discount)) / 100;
            actualPrice = this.regularPrice - priceWithDiscount;

            Console.WriteLine($"Product: Name: {productName}, Regular Price: {regularPrice}, Discount: {discount}%, Actual Price: {actualPrice}");
        }
    }
}
