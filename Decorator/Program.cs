using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Syrop syropLatte = new Syrop(new Latte());
            syropLatte.Print();
            Discount discountedSyrupLatte = new Discount(syropLatte);
            discountedSyrupLatte.Print();
            Lemon lemonCappuccino = new Lemon(new Cappuccino());
            lemonCappuccino.Print();
            Console.ReadLine();
        }
    }
}
