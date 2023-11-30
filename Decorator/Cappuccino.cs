using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Cappuccino : Coffee
    {
        public Cappuccino()
            : base(15)
        { }
        public override void Print()
        {
            Console.WriteLine($"Цена капучино: {Price()} руб");
        }   
    }
}
