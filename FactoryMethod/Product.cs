using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteProductA : IProduct
    {
        // A پیاده سازی
        public void Print()
        {
            Console.WriteLine("Class A");
        }
    }

    public class ConcreteProductB : IProduct
    {
        // B پیاده سازی
        public void Print()
        {
            Console.WriteLine("Class B");
        }
    }
}
