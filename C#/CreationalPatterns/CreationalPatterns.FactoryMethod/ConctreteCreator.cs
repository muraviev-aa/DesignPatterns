namespace CreationalPatterns.FactoryMethod
{
    class ConctreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
