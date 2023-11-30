using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Latte : Coffee
    {
        public Latte()
            : base(10)
        { }
        public override void Print()
        {
            Console.WriteLine($"Цена латте: {Price()} руб");
        }
    }
}
