using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteCreator:Creator
    {
        public override IProduct FactoryMethod(string type)
        {
            switch (type)
            {
                case "A": return new ConcreteProductA();
                case "B": return new ConcreteProductB();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
