using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AdishCoffeeDecorator : Coffee
    {
        private Coffee _coffee;


        public AdishCoffeeDecorator(Coffee coffee, double adishPrice)
            : base(adishPrice)
        {
            if (coffee == null)
            {
                throw new ArgumentNullException(nameof(coffee), "Кофе не может быть пустым.");
            }

            _coffee = coffee;
        }

        public override double Price()
        {
            return _coffee.Price() + base.Price();
        }
        public override void Print()
        {
            _coffee.Print();
        }

    }
}
