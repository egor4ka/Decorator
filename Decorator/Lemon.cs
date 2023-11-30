using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Lemon : AdishCoffeeDecorator
    {
        public Lemon(Coffee coffee)
            : base(coffee, 1)
        { }
        public override void Print()
        {
            Console.WriteLine($"Цена кофе с лимоном: {Price()} руб");
        }
    }
}
