namespace CreationalPatterns.FactoryMethod
{
    class Program
    {
        static void Main()
        {
            Creator creator = new ConctreteCreator();
            Product product = creator.FactoryMethod();

            creator.AnOperation();
        }
    }
}
