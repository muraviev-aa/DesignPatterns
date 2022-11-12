namespace CreationalPatterns.AbstractFactory
{
    internal interface IDocumentConverterFactory
    {
        IDocumentConverter CreateConverter();
    }
}
