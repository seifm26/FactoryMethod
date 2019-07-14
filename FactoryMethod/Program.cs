using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator  factory = new ConcreteCreator();
            IProduct product = factory.FactoryMethod("B");
            product.Print();
            Console.ReadKey();
        }
    }
}
