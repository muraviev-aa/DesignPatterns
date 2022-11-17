using System;

namespace CreationalPatterns.FactoryMethod
{
    class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
