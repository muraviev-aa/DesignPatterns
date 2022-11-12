namespace CreationalPatterns.AbstractFactory
{
    internal class CsvConverterFactory : IDocumentConverterFactory
    {
        public IDocumentConverter CreateConverter()
        {
            return new CsvConverter();
        }
    }
}
