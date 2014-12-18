using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineddTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Item aItem = new Item();
            aItem.name = "Mouse";
            aItem.unitPrice = 200;
            aItem.discountPrice = 50;

            string itemName = aItem.name;
            double itemPrice = aItem.unitPrice;
            double itemDiscount = aItem.discountPrice;
            Console.WriteLine("Name of the Item:" +itemName+ "\nPrice of the Item:" +itemPrice);
            Console.Read();

        }
    }
}
