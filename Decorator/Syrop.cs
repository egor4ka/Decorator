using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Syrop : AdishCoffeeDecorator
    {
        public Syrop(Coffee coffee)
            : base(coffee, 2)
        { }
        public override void Print()
        {
            Console.WriteLine($"Цена кофе с сиропом: {Price()} руб");
        }
    }
}
