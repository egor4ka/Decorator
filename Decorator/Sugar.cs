using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Sugar : AdishCoffeeDecorator
    {
        public Sugar(Coffee coffee)
            : base(coffee, 1)
        { }
        public override void Print()
        {
            Console.WriteLine($"Цена кофе с сахаром: {Price()} руб");
        }
    }
}
